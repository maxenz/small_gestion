using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Model;

namespace FrbaCommerce.Login
{
    public partial class RolesForm : Form
    {
        public Usuario Usuario;
        public RolesForm(Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            CargarRoles();
        }

        private void CargarRoles()
        {
            var roles = DAORol.getRolesUsuario(Usuario.Id);
            lbListaRoles.DataSource = roles.DefaultView;
            lbListaRoles.DisplayMember = "Nombre";
            lbListaRoles.ValueMember = "ID";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario.RolActivo = (int) lbListaRoles.SelectedValue;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
