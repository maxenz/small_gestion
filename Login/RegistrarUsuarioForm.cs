using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.Abm_Empresa;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Helpers;
using FrbaCommerce.Model;

namespace FrbaCommerce.Login
{
    public partial class RegistrarUsuarioForm : Form
    {
        private Form _padre;
        private int personaId;

        public RegistrarUsuarioForm(Form padre, string user)
        {
            InitializeComponent();
            _padre = padre;
            tbUsuario.Text = user;

            cbTipoDoc.DataSource = DAOCliente.TiposDocumento().DefaultView;
            cbTipoDoc.DisplayMember = "Descripcion";
        
            cbTipoUsuario.DataSource = new List<string> {"Cliente","Empresa"};
        }

        private bool ValidarUsuario()
        {
            if (!DAOUsuario.UsuarioExistente(tbUsuario.Text)) return true;
            MessageBox.Show("El usuario ingresado ya existe.");
            return false;
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbTipoUsuario.SelectedIndex;
            switch (index)
            {
                case 0:
                    pnlCliente.Visible = true;
                    pnlEmpresa.Visible = false;
                    break;
                case 1:
                    pnlCliente.Visible = false;
                    pnlEmpresa.Visible = true;
                    break;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!ValidarUsuario() || !ValidacioCliente()) return;
            try
            {
                personaId = DAOCliente.AgregarCliente(GenerarCliente());
                DAOUsuario.AgregarUsuario(personaId, tbUsuario.Text, tbPass.Text, 3);

                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show("Completar todos los campos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }

        }

        private void btnAltaEmpresa_Click(object sender, EventArgs e)
        {
            if (!ValidacionEmpresa() || !ValidarUsuario()) return;
            try
            {
                personaId = DAOEmpresa.AgregarEmpresa(GenerarEmpresa());
                DAOUsuario.AgregarUsuario(personaId, tbUsuario.Text, tbPass.Text, 1);

                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show("Completar todos los campos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }

        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b')) e.Handled = true;
        }

        #region Empresa
        private Empresa GenerarEmpresa()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                if (control.Text == "") throw new ValidationException(control.Name);
            }

            var persona = new Persona
            {
                calle = tbCalle.Text,
                nroCalle = Convert.ToInt32(tbNroCalle.Text),
                ciudad = tbCiudad.Text,
                codPostal = tbCodigoPostal.Text,
                departamento = tbDepartamento.Text,
                eMail = tbEMail.Text,
                localidad = tbLocalidad.Text,
                piso = tbPiso.Text,
                telefono = tbTelefono.Text
            };
            return new Empresa(persona, tbRazonSocial.Text, tbCuit.Text, tbNombreContacto.Text, dtpFechaCreacion.Value);

        }

        private bool ValidacionEmpresa()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarCuit() != null) listaDeErrores.Add(ValidarCuit());
            if (ValidarRazonSocial() != null) listaDeErrores.Add(ValidarRazonSocial());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarRazonSocial()
        {
            return DAOEmpresa.existeRazonSocial(tbRazonSocial.Text) ? new Error("La Razon Social ingresada ya está asociada a un usuario registrado.") : null;
        }

        private Error ValidarCuit()
        {
            if (tbTelefono.Text == "") return null;
            return DAOEmpresa.existeCuit(tbCuit.Text) ? new Error("El CUIT ingresado ya está asociado a un usuario registrado.") : null;
        }
        #endregion

        #region Cliente
        private bool ValidacioCliente()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarDni() != null) listaDeErrores.Add(ValidarDni());
            if (ValidarTelefono() != null) listaDeErrores.Add(ValidarTelefono());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarDni()
        {
            return DAOCliente.existeDni(tbDni.Text, cbTipoDoc.SelectedIndex + 1) ? new Error("El documento ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Error ValidarTelefono()
        {
            if (tbTelefono.Text == "") return null;
            return DAOCliente.existeTelefono(tbTelefono.Text) ? new Error("El telefono ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Cliente GenerarCliente()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                if (control.Text == "") throw new ValidationException(control.Name);
            }
            var persona = new Persona
            {
                calle = tbCalle.Text,
                nroCalle = Convert.ToInt32(tbNroCalle.Text),
                ciudad = tbCiudad.Text,
                codPostal = tbCodigoPostal.Text,
                departamento = tbDepartamento.Text,
                eMail = tbEMail.Text,
                localidad = tbLocalidad.Text,
                piso = tbPiso.Text,
                telefono = tbTelefono.Text
            };
            return new Cliente(persona, tbNombre.Text, tbApellido.Text, tbDni.Text, tbCuil.Text, (byte)(cbTipoDoc.SelectedIndex + 1), dtpFechaNac.Value);
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
            dtpFechaNac.Value = new DateTime(1996, 1, 1);
        }
    }
}
