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

namespace FrbaCommerce.ModificarPassword
{
    public partial class frmModificarPassword : Form
    {
        Form _padre;
        Seguridad seg = new Seguridad();
        public frmModificarPassword(Form padre)
        {
            _padre = padre;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int selUserID = Convert.ToInt32(cmbUsuario.SelectedValue);

            CapaADO.DAOUsuario.changePassword(selUserID, seg.hash(txtPassword.Text));
            MessageBox.Show("El password ha sido modificado");
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
    }
}
