using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Modelo;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class ModVisibilidadForm : Form
    {
        private int _id;
        private FiltrarVisibilidadForm _padre;
        private Visibilidad visib;
        public ModVisibilidadForm(int id, FiltrarVisibilidadForm padre)
        {
            InitializeComponent();
            _padre = padre;
            _id = id;
            visib = GetVisib(id);
            CargarComponentes();
            tbCodigo.Enabled = false;
        }

        private void CargarComponentes()
        {
            tbCodigo.Text = _id.ToString();
            tbDescripcion.Text = visib.Descripcion;
            tbPrecio.Text = visib.Precio.ToString();
            tbPorcentaje.Text = (visib.Porcentaje * 100).ToString();
        }

        private void ModVisibilidadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private Visibilidad GetVisib(int id)
        {
            var dt = SqlConnector.retrieveDataTable("getVisibilidad", id);
            var dr = dt.Rows[0];
            return new Visibilidad
            (
               Convert.ToInt32(dr["ID"]),
               dr["Descripcion"].ToString(),
               Convert.ToDouble(dr["Precio"]),
               Convert.ToDouble(dr["Porcentaje"]),
               Convert.ToBoolean(dr["Activo"]),
               Convert.ToInt32(dr["Dias_Activo"]),
               Convert.ToInt32(dr["Contador"])
            );
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;
            try
            {
                AgregarVisibilidad(GenerarVisibilidad());
                MessageBox.Show("Visibilidad modificada correctamente");
                _padre.CargarGrid();
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

        private void AgregarVisibilidad(Visibilidad visib)
        {
            SqlConnector.executeProcedure("updateVisibilidad", _id, visib.Descripcion, visib.Precio, visib.Porcentaje,0,
                visib.Activo, visib.DiasActivo);
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


    }
}
