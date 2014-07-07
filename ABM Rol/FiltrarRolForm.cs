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

namespace FrbaCommerce.ABM_Rol
{
    public partial class FiltrarRolForm : Form
    {
        private Form _padre;
        public FiltrarRolForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
            CargarGrid();
        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = DAORol.getRoles();

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void FiltrarRolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void FiltrarRolForm_Activated(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = DAORol.getRoles();
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Modificar.DisplayIndex) ModificarRol(e.RowIndex);
            if (e.ColumnIndex == Baja.DisplayIndex) BajaRol(e.RowIndex);
        }

        private void BajaRol(int rowIndex)
        {
            bool habilitado = (bool)dataGridView1["Activo", rowIndex].Value;
            string msg = "";
            msg = habilitado ? "¿Desea inhabilitar el rol?" : "¿Desea habilitar el rol?";
            int val = habilitado ? 0 : 1;
            int id = (int)dataGridView1["ID", rowIndex].Value;
            var dr = MessageBox.Show(msg, "Atención!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DAORol.BajaRol(id, val);
                if (val == 0)
                {
                    DAORol.eliminarRolDeUsuarios(id);
                }
 
            }

            dataGridView1.DataSource = DAORol.getRoles();
        }

        private void ModificarRol(int rowIndex)
        {
            int id = (int)dataGridView1["ID", rowIndex].Value;
            this.Hide();
            new ModificarRolForm(id, this).Show();
        }
    }
}
