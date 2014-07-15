using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.ManejoDeUsuarios
{
    public partial class frmManejoUsuarios : Form
    {
        Form _padre;
        int _vieneDePrimerIngreso;
        Seguridad seg = new Seguridad();
        public frmManejoUsuarios(Form padre, int vieneDePrimerIngreso)
        {
            _padre = padre;
            _vieneDePrimerIngreso = vieneDePrimerIngreso;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int selUserID = Convert.ToInt32(cmbUsuario.SelectedValue);

            CapaADO.DAOUsuario.changePassword(selUserID, seg.hash(txtPassword.Text));
            MessageBox.Show("El password ha sido modificado");
            if (_vieneDePrimerIngreso == 1)
            {
                MessageBox.Show("Ha cambiado su password después de su primer ingreso, vuelva a loguearse por favor");
                Application.Exit();
            }
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }

        private void CambiarPassword_Load(object sender, EventArgs e)
        {
            this.cmbUsuario.DisplayMember = "NombreUsuario";
            this.cmbUsuario.ValueMember = "Id";
            List<Usuario> lstUsers = CapaADO.DAOUsuario.getUsuarios();
            this.cmbUsuario.DataSource = lstUsers;

            if (!Globals.adminLoggeado())
            {
                cmbUsuario.DataSource = lstUsers.Where(x => x.Id == Globals.userID).ToList<Usuario>();
            }
        }

        private void frmManejoUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_vieneDePrimerIngreso == 1)
            {
                MessageBox.Show("Error, password no modificado");
                Application.Exit();
            }
            FormHelper.volverAPadre(_padre);
        }

    }
}
