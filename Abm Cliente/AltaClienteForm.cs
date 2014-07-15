using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class AltaClienteForm : Form
    {
        private Form _padre;
        private CleanFormHelper cfh = new CleanFormHelper();
        private Seguridad seg = new Seguridad();
        
        public AltaClienteForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;

            cbTipoDoc.ValueMember = "ID";
            cbTipoDoc.DisplayMember = "Descripcion";
            cbTipoDoc.DataSource = DAOCliente.TiposDocumento();
        }
        private void AltaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
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
            dtpFechaNac.Value = new DateTime(1996,1,1);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!clienteValidado()) return;

            if (!Validaciones()) return;
            try
            {
                Cliente cli = GenerarCliente();
                DAOCliente.AgregarCliente(cli);
                int perID = DAOPersona.GetLastPersonaID();
                string user = cli.Apellido.Substring(0,3);
                user = user + cli.Documento.Substring(0,3);
                string password = seg.hash(user);
                DAOUsuario.AgregarUsuarioAuto(perID, user, password, 3);
                MessageBox.Show("Cliente agregado correctamente.");
                this.Hide();
                FormHelper.volverAPadre(_padre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }

        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarDni() != null) listaDeErrores.Add(ValidarDni());
            if(ValidarTelefono() != null) listaDeErrores.Add(ValidarTelefono());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private void validateTextbox(string texto, string error, ref bool vBool, Label lbl)
        {

            if (texto == "")
            {
                errorProvider1.SetError(lbl, error);
                vBool = false;
            }
        }

        private bool clienteValidado()
        {
            cfh.cleanErrorProviderInLabels(this.Controls, errorProvider1);
            bool vBool = true;

            validateTextbox(tbNombre.Text, "Debe ingresar el nombre", ref vBool, lblNombre);
            validateTextbox(tbApellido.Text, "Debe ingresar el apellido", ref vBool, lblApellido);
            validateTextbox(tbCuil.Text, "Debe ingresar el CUIL", ref vBool, lblCUIL);
            validateTextbox(tbEMail.Text, "Debe ingresar el EMAIL", ref vBool, lblEmail);
            validateTextbox(tbTelefono.Text, "Debe ingresar el Teléfono", ref vBool, lblTelefono);
            validateTextbox(tbCalle.Text, "Debe ingresar la calle", ref vBool, lblCalle);
            validateTextbox(tbNroCalle.Text, "Debe ingresar el nro de la calle", ref vBool, lblNumero);
            validateTextbox(tbDni.Text, "Debe ingresar el nro de documento", ref vBool, lblDNI);

            return vBool;
        }

        private Error ValidarDni()
        {
            return DAOCliente.existeDni(tbDni.Text, Convert.ToInt32(cbTipoDoc.SelectedValue))? new Error("El documento ingresado ya está asignado a un usuario registrado."):null;
        }

        private Error ValidarTelefono()
        {
            return DAOCliente.existeTelefono(tbTelefono.Text) ? new Error("El telefono ingresado ya está asignado a un usuario registrado.") : null;
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
            return new Cliente(persona,tbNombre.Text,tbApellido.Text,tbDni.Text,tbCuil.Text,Convert.ToInt32(cbTipoDoc.SelectedValue),dtpFechaNac.Text, tbTelefono.Text);
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b')) e.Handled = true;
        }

        private void tbPiso_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(tbPiso.Text) > 255) tbPiso.Text = "";
        }

    }
}
