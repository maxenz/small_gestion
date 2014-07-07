using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.DAO;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Modelo;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class AltaVisibilidadForm : Form
    {
        private Form _padre;
        public AltaVisibilidadForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;
            try
            {
                AgregarVisibilidad(GenerarVisibilidad());
                MessageBox.Show("Visibilidad agregada correctamente");
                Close();
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

        private void AgregarVisibilidad(Visibilidad visib)
        {
            SqlConnector.executeProcedure("agregarVisibilidad",visib.ID, visib.Descripcion, visib.Precio, visib.Porcentaje,
                visib.Activo);
        }

        private bool Validaciones()
        {
            return true;
        }

        private Visibilidad GenerarVisibilidad()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                if (control.Text == "") throw new ValidationException(control.Name);
            }
            var visibilidad = new Visibilidad
            (
                Convert.ToInt32(tbCodigo.Text),
                tbDescripcion.Text,
                Convert.ToDouble(tbPrecio.Text),
                Convert.ToDouble(tbPorcentaje.Text),
                true,
                Convert.ToInt32(txtDiasActivo.Text),
                0
            );
            return visibilidad;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b')) e.Handled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
        }

        private void AltaVisibilidadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _padre.Enabled = true;
        }

    }
}
