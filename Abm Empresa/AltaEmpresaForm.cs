using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class AltaEmpresaForm : Form
    {
        private AbmEmpresaForm _padre;
        private Seguridad seg = new Seguridad();
        CleanFormHelper cfh = new CleanFormHelper();

        public AltaEmpresaForm(AbmEmpresaForm padre)
        {
            InitializeComponent();
            _padre = padre;
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
            dtpFechaCreacion.Value = DateTime.Today;
        }

        private void AltaEmpresaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!empresaValidada()) return;
            if (!Validaciones()) return;

            try
            {
                Empresa emp = GenerarEmpresa();
                DAOEmpresa.AgregarEmpresa(emp);
                int perID = DAOPersona.GetLastPersonaID();
                string user = emp.RazonSocial.Substring(0, 3);
                user = user + emp.Cuit.Substring(0, 5);
                string password = seg.hash(user);
                DAOUsuario.AgregarUsuarioAuto(perID, user, password, 3);
                MessageBox.Show("Empresa agregada correctamente.");
                this.Hide();
                FormHelper.volverAPadre(_padre);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }

        }

        private void validateTextbox(string texto, string error, ref bool vBool, Label lbl)
        {

            if (texto == "")
            {
                errorProvider1.SetError(lbl, error);
                vBool = false;
            }
        }

        private bool empresaValidada()
        {
            cfh.cleanErrorProviderInLabels(this.Controls, errorProvider1);
            bool vBool = true;

            validateTextbox(tbRazonSocial.Text, "Debe ingresar la razón social", ref vBool, lblRazonSocial);
            validateTextbox(tbNombreContacto.Text, "Debe ingresar el apellido", ref vBool, lblNomContacto);
            validateTextbox(tbCuit.Text, "Debe ingresar el CUIT", ref vBool, lblCUIT);
            validateTextbox(tbEMail.Text, "Debe ingresar el EMAIL", ref vBool, lblEmail);
            validateTextbox(tbTelefono.Text, "Debe ingresar el Teléfono", ref vBool, lblTelefono);
            validateTextbox(tbCalle.Text, "Debe ingresar la calle", ref vBool, lblCalle);
            validateTextbox(tbNroCalle.Text, "Debe ingresar el nro de la calle", ref vBool, lblNumero);

            return vBool;
        }

        private bool Validaciones()
        {
            try
            {
                if (tbCuit.Text.Count() > 50) throw new Exception("Cuit demasiado largo");
                if (DAOEmpresa.existeCuit(tbCuit.Text)) throw new Exception("Cuit existente");
                if (DAOEmpresa.existeRazonSocial(tbRazonSocial.Text)) throw new Exception("Razón Social existente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

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

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFechaCreacion.Value = DateTime.Today;
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
