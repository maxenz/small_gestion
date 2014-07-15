using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class FiltrarClienteForm : Form
    {
        private Form _padre;

        public FiltrarClienteForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        public void CargarGrid()
        {
            var dt = FiltrarCliente(tbNombre.Text,tbApellido.Text,Convert.ToInt32(cbTipo.SelectedValue),tbDoc.Text,tbMail.Text);
            dataGridView1.DataSource = dt;
                       
            dataGridView1.Columns["ID_Persona"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        public DataTable FiltrarCliente(string nom, string ape, int tipoDoc, string doc, string mail)
        {
            var dt = DAOCliente.getClienteTable();
            var filtroFinal = "";
            var filtros = new List<string>();
            var esPrimero = true;
            if (nom != "") filtros.Add("Nombre LIKE '%" + nom + "%'");
            if (ape != "") filtros.Add("Apellido LIKE '%" + ape + "%'");
            if (mail != "") filtros.Add("Mail LIKE '%" + mail + "%'");
            if (doc != "") filtros.Add("Num_Doc = " + doc);
            if (tipoDoc != 0) filtros.Add("Tipo_Doc = " + tipoDoc);

            foreach (var filt in filtros)
            {
                if (!esPrimero) { filtroFinal += " AND " + filt; }
                else { filtroFinal += filt; esPrimero = false; }

            }
            dt.DefaultView.RowFilter = filtroFinal;
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Modificar.DisplayIndex) ModificarCliente(e.RowIndex);
            if (e.ColumnIndex == Baja.DisplayIndex) BajaCliente(e.RowIndex);

        }

        private void BajaCliente(int rowIndex)
        {
            bool habilitado = (bool)dataGridView1["Activo", rowIndex].Value;
            string msg = "";
            msg = habilitado ? "¿Desea inhabilitar al cliente?" : "¿Desea habilitar al cliente?";
            int val = habilitado ? 0 : 1;
            int id = (int)dataGridView1["ID_Persona", rowIndex].Value;
            var dr = MessageBox.Show(msg, "Atención!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DAOPersona.BajaPersona(id, val);
                string msgFinal = habilitado ? "El cliente ha sido inhabilitado" : "El cliente ha sido habilitado";
                MessageBox.Show(msgFinal);
                var dt = FiltrarCliente(tbNombre.Text, tbApellido.Text, Convert.ToInt32(cbTipo.SelectedValue), tbDoc.Text, tbMail.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void ModificarCliente(int rowIndex)
        {
            int id = (int)dataGridView1["ID_Persona", rowIndex].Value;
            new ModClienteForm(id,this).Show();
        }

        private void FiltrarClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void FiltrarClienteForm_Load(object sender, EventArgs e)
        {
            cbTipo.ValueMember = "ID";
            cbTipo.DisplayMember = "Descripcion";
            cbTipo.DataSource = DAOCliente.TiposDocumento();
            cbTipo.SelectedItem = null;
        }

    }
}
