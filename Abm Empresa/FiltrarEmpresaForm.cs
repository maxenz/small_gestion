using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class FiltrarEmpresaForm : Form
    {
        private Form _padre;

        public FiltrarEmpresaForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        public void CargarGrid()
        {
            dataGridView1.DataSource = FiltrarEmpresa(tbEmail.Text, tbRazonSocial.Text, tbCuit.Text);

            dataGridView1.Columns["ID_Persona"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Modificar.DisplayIndex) ModificarEmpresa(e.RowIndex);
            if (e.ColumnIndex == Baja.DisplayIndex) BajaEmpresa(e.RowIndex);

        }

        public DataTable FiltrarEmpresa(string email, string razon, string cuit)
        {
            var dt = DAOEmpresa.getEmpresaTable();
            var filtroFinal = "";
            var filtros = new List<string>();
            bool esPrimero = true;

            if (cuit != "") filtros.Add("Cuit = '" + cuit + "'");
            if (razon != "") filtros.Add("Razon_Social LIKE '%" + razon + "%'");
            if (email != "") filtros.Add("Mail LIKE '%" + email + "%'");

            foreach (var filt in filtros)
            {
                if (!esPrimero) {filtroFinal += " AND " + filt;}
                else { filtroFinal += filt; esPrimero = false; }
            }
            dt.DefaultView.RowFilter = filtroFinal;
            return dt;
        }

        private void BajaEmpresa(int rowIndex)
        {
            bool habilitado = (bool)dataGridView1["Activo", rowIndex].Value;
            string msg = "";
            msg = habilitado ? "¿Desea inhabilitar a la empresa?" : "¿Desea habilitar a la empresa?";
            int val = habilitado ? 0 : 1;
            int id = (int)dataGridView1["ID_Persona", rowIndex].Value;
            var dr = MessageBox.Show(msg, "Atención!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DAOPersona.BajaPersona(id, val);
                string msgFinal = habilitado ? "La empresa ha sido inhabilitada" : "La empresa ha sido habilitada";
                MessageBox.Show(msgFinal);
                CargarGrid();
            }
        }

        private void ModificarEmpresa(int rowIndex)
        {
            int id = (int)dataGridView1["ID_Persona", rowIndex].Value;
            new ModificarEmpresaForm(id,this).Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void FiltrarEmpresaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }
    }
}
