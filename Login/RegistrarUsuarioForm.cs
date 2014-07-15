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
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Login
{
    public partial class RegistrarUsuarioForm : Form
    {
        private Seguridad seg = new Seguridad();
        private Form _padre;
        private int personaId;

        public RegistrarUsuarioForm(Form padre, string user)
        {
            InitializeComponent();
            _padre = padre;
            tbUsuario.Text = user;

            cbTipoDoc.DisplayMember = "Descripcion";
            cbTipoDoc.ValueMember = "ID";
            cbTipoDoc.DataSource = DAOCliente.TiposDocumento();


            DataTable dt = CapaADO.DAORol.getRoles();
            List<Rol> lstRoles = new List<Rol>();
            foreach (DataRow r in dt.Rows)
            {
                lstRoles.Add(CapaADO.DAORol.dataRowToRol(r));
            }

            lstRoles = lstRoles.Where(x => (x.Nombre == "Empresa") || (x.Nombre == "Cliente")).ToList();
            cbTipoUsuario.DataSource = lstRoles;
            cbTipoUsuario.DisplayMember = "Nombre";
            cbTipoUsuario.ValueMember = "Codigo";
            cbTipoUsuario.Text = "Cliente";

            
        }

        private bool ValidarUsuario()
        {
            if (!DAOUsuario.UsuarioExistente(tbUsuario.Text)) return true;
            MessageBox.Show("El usuario ingresado ya existe.");
            return false;
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var desc = cbTipoUsuario.Text;
            var prueba = cbTipoUsuario.SelectedValue;
            switch (desc)
            {
                case "Cliente":
                    pnlCliente.Visible = true;
                    pnlEmpresa.Visible = false;
                    break;
                case "Empresa":
                    pnlCliente.Visible = false;
                    pnlEmpresa.Visible = true;
                    break;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!personaValidada()) return;

            if (!clienteValidado()) return;

            if (!ValidarUsuario() || !ValidacioCliente()) return;
            try
            {
                
                personaId = DAOCliente.AgregarCliente(GenerarCliente());
                DAOUsuario.AgregarUsuario(personaId, tbUsuario.Text, seg.hash(tbPass.Text), 
                    Convert.ToInt32(cbTipoUsuario.SelectedValue));

                MessageBox.Show("Usuario agregado correctamente.");
                this.Hide();
                FormHelper.volverAPadre(_padre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
         

        }

        private void btnAltaEmpresa_Click(object sender, EventArgs e)
        {
            if (!personaValidada()) return;
            if (!empresaValidada()) return;
            if (!ValidacionEmpresa() || !ValidarUsuario()) return;
            try
            {
                personaId = DAOEmpresa.AgregarEmpresa(GenerarEmpresa());
                DAOUsuario.AgregarUsuario(personaId, tbUsuario.Text, seg.hash(tbPass.Text), Convert.ToInt32(cbTipoUsuario.SelectedValue));

                MessageBox.Show("Usuario agregado correctamente.");
                this.Hide();
                FormHelper.volverAPadre(_padre);
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

            var persona = new Persona
            {
                Domicilio_Calle = tbCalle.Text,
                Nro_Calle = Convert.ToInt32(tbNroCalle.Text),
                Ciudad = tbCiudad.Text,
                Cod_Postal = tbCodigoPostal.Text,
                Departamento = tbDepartamento.Text,
                Mail = tbEMail.Text,
                Localidad = tbLocalidad.Text,
                Piso = tbPiso.Text,
                Telefono = tbTelefono.Text
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

        // --> Limpio los error providers del form
        private void cleanErrorProviderInLabels()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    errorProvider1.SetError(ctrl, "");
                }
            }

        }

        private bool personaValidada()
        {

            cleanErrorProviderInLabels();
            bool vBool = true;

            validateTextbox(tbUsuario.Text, "Debe ingresar el numero de usuario",ref vBool, lblUsuario);
            validateTextbox(tbPass.Text, "Debe ingresar la contraseña",ref vBool, lblPassword);
            validateTextbox(tbEMail.Text, "Debe ingresar el email",ref vBool, lblEmail);
            validateTextbox(tbTelefono.Text, "Debe ingresar el teléfono",ref vBool, lblTelefono);
            validateTextbox(tbCalle.Text, "Debe ingresar la calle",ref vBool, lblCalle);
            validateTextbox(tbCodigoPostal.Text, "Debe ingresar el cod postal",ref vBool, lblCodPostal);
            validateTextbox(tbNroCalle.Text, "Debe ingresar el número de calle",ref vBool, lblNumero);

            return vBool;
        }

        private bool clienteValidado()
        {
            cleanErrorProviderInLabels();
            bool vBool = true;

            validateTextbox(tbNombre.Text, "Debe ingresar el nombre del cliente",ref vBool, lblNombreCliente);
            validateTextbox(tbApellido.Text, "Debe ingresar el apellido del cliente",ref vBool, lblApellidoCliente);
            validateTextbox(tbCuil.Text, "Debe ingresar el CUIL", ref vBool, lblCUIL);
            validateTextbox(tbDni.Text, "Debe ingresar el DNI",ref  vBool, lblDocumentoCliente);

            return vBool;
        }

        private bool empresaValidada()
        {
            cleanErrorProviderInLabels();
            bool vBool = true;

            validateTextbox(tbRazonSocial.Text, "Debe ingresar la Razón Social", ref vBool, lblRazonSocial);
            validateTextbox(tbNombreContacto.Text, "Debe ingresar el nombre del contacto",ref vBool, lblNombreRazonSocial);
            validateTextbox(tbCuit.Text, "Debe ingresar el CUIT", ref vBool, lblCUIT);

            return vBool;
        }

        private void validateTextbox(string texto, string error,ref bool vBool, Label lbl) {

            if (texto == "")
            {
                errorProvider1.SetError(lbl, error);
                vBool = false;
            }
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
            Persona persona = new Persona
            {
                Domicilio_Calle = tbCalle.Text,
                Nro_Calle = Convert.ToInt32(tbNroCalle.Text),
                Ciudad = tbCiudad.Text,
                Cod_Postal = tbCodigoPostal.Text,
                Departamento = tbDepartamento.Text,
                Mail = tbEMail.Text,
                Localidad = tbLocalidad.Text,
                Piso = tbPiso.Text,
                Telefono = tbTelefono.Text
            };
            return new Cliente(persona, tbNombre.Text, tbApellido.Text, tbDni.Text, tbCuil.Text, Convert.ToInt32(cbTipoDoc.SelectedValue), dtpFechaNac.Text, tbTelefono.Text);
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
