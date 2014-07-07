using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.ABM_Rol
{
    public partial class ModificarRolForm : Form
    {
        private Form _padre;
        private Rol _rol;

        public ModificarRolForm(int id, Form padre)
        {
            InitializeComponent();
            _padre = padre;
            CargarRol(id);
            tbNombre.Text = _rol.Nombre;
            CargarFuncionalidades();
        }



        private void CargarRol(int id)
        {
            _rol = DAORol.getRol(id);
        }

        private void CargarFuncionalidades()
        {
            clbFuncionalidades.DisplayMember = "Descripcion";
            clbFuncionalidades.ValueMember = "ID";
            clbFuncionalidades.DataSource = DAOFuncionalidades.getFuncionalidades();

            // --> Voy seleccionando los rubros en la lista
            for (int i = 0; i < clbFuncionalidades.Items.Count; i++)
            {
                Funcionalidad f = (Funcionalidad)clbFuncionalidades.Items[i];
                if (_rol.Funcionalidades.Exists(x => x == f.getCodFuncionalidad()))
                {
                    clbFuncionalidades.SetSelected(i, true);
                }
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;
            try
            {
                DAORol.UpdateRol(GenerarRol());
                MessageBox.Show("Rol modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
            
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }

        private void ModificarRolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            if (clbFuncionalidades.SelectedItems.Count == 0) listaDeErrores.Add(new Error("Debe seleccionar al menos una Funcionalidad."));

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Rol GenerarRol()
        {
            List<int> lst = new List<int>();
            foreach (Funcionalidad f in clbFuncionalidades.SelectedItems)
            {
                lst.Add(f.getCodFuncionalidad());
            }
            Rol rol = new Rol(tbNombre.Text, lst);
            rol.Codigo = _rol.Codigo;
            return rol;
        }
    }
}
