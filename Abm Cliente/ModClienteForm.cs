using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Helpers;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ModClienteForm : Form
    {
        private Cliente _cliente;
        private Form _padre;
        private int ID;
        public ModClienteForm(int id, Form padre)
        {
            InitializeComponent();
            _padre = padre;
            _padre.Enabled = false;
            _cliente = DAOCliente.getCliente(id);
            ID = id;
            cbTipoDoc.DataSource = DAOCliente.TiposDocumento().DefaultView;
            cbTipoDoc.DisplayMember = "Descripcion";
            CargarComponentes();
        }

        private void CargarComponentes()
        {
            var p = _cliente.Persona;

            tbCalle.Text = p.Domicilio_Calle;
            tbNroCalle.Text = p.Nro_Calle.ToString();
            tbCiudad.Text = p.Ciudad;
            tbCodigoPostal.Text = p.Cod_Postal;
            tbDepartamento.Text = p.Departamento;
            tbEMail.Text = p.Mail;
            tbLocalidad.Text = p.Localidad;
            tbPiso.Text = p.Piso.ToString();
            tbTelefono.Text = p.Telefono;

            tbNombre.Text = _cliente.Nombre;
            tbApellido.Text = _cliente.Apellido;
            tbDni.Text = _cliente.Documento;
            tbCuil.Text = _cliente.Cuil;
            cbTipoDoc.SelectedIndex = _cliente.TipoDoc - 1;
            dtpFechaNac.Text = _cliente.FechaDeNacimiento;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {

                try
                {
                    DAOCliente.UpdateCliente(GenerarCliente(), ID);
                    MessageBox.Show("Cliente modificado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error." + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error en la validacion de datos. Corroborá que todos los campos ingresados esten llenos con la imformación correcta.");
            }
            Close();
        }

        private Cliente GenerarCliente()
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
            return new Cliente(persona, tbNombre.Text, tbApellido.Text, tbDni.Text, tbCuil.Text, (byte)(cbTipoDoc.SelectedIndex + 1), dtpFechaNac.Text);
        }

        private bool Validaciones()
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
            return (DAOCliente.existeDni(tbDni.Text, cbTipoDoc.SelectedIndex + 1) && tbDni.Text != _cliente.Documento )? new Error("El documento ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Error ValidarTelefono()
        {
            return (DAOCliente.existeTelefono(tbTelefono.Text) && tbDni.Text != _cliente.Documento )? new Error("El telefono ingresado ya está asignado a un usuario registrado.") : null;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
            dtpFechaNac.Value = new DateTime(1996, 1, 1);
        }

        private void ModClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _padre.Enabled = true;
        }
    }
}
