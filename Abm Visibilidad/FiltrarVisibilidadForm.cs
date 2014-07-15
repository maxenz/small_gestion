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
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class FiltrarVisibilidadForm : Form
    {
        private Form _padre;
        public FiltrarVisibilidadForm(Form padre)
        {
            InitializeComponent(); 
            _padre = padre;
            CargarGrid();
        }

        public void CargarGrid()
        {
            dataGridView1.DataSource = ADOVisibilidad.getVisibilidades();

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void FiltrarVisibilidadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void BajaVisib(int rowIndex)
        {
            bool habilitado = (bool)dataGridView1["Activo", rowIndex].Value;
            string msg = "";
            msg = habilitado ? "¿Desea inhabilitar la visibilidad?" : "¿Desea habilitar la visibilidad?";
            int val = habilitado ? 0 : 1;
            int id = (int)dataGridView1["ID", rowIndex].Value;
            var dr = MessageBox.Show(msg, "Atención!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                BajarVisib(id, val);
                string msgFinal = habilitado ? "La visibilidad ha sido inhabilitada" : "La visibilidad ha sido habilitada";
                MessageBox.Show(msgFinal);
                CargarGrid();
            }
        }

        private void BajarVisib(int id, int activo)
        {
            SqlConnector.executeProcedure("bajaVisibilidad",id,activo);
        }

        private void ModificarVisib(int rowIndex)
        {
            int id = (int)dataGridView1["ID", rowIndex].Value;
            new ModVisibilidadForm(id,this).Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Modificar.DisplayIndex) ModificarVisib(e.RowIndex);
            if (e.ColumnIndex == Baja.DisplayIndex) BajaVisib(e.RowIndex);
        }

        private void FiltrarVisibilidadForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _padre.Enabled = true;
        }
    }
}
