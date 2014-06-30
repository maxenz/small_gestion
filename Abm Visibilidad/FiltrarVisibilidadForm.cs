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

        private void CargarGrid()
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
            var dr = MessageBox.Show("¿Activar Visibilidad?", "Baja de Visibilidad", MessageBoxButtons.YesNo);
            int id = (int)dataGridView1["ID", rowIndex].Value;

            BajarVisib(id, dr == DialogResult.Yes ? 1 : 0);
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
