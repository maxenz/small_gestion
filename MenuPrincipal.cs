﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.ABM_Rol;
using FrbaCommerce.Comprar_Ofertar;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Helpers;
using FrbaCommerce.Login;
using FrbaCommerce.Abm_Empresa;
using FrbaCommerce.Modelo;
using FrbaCommerce.ManejoDeUsuarios;

namespace FrbaCommerce
{
    public partial class MenuPrincipal : Form
    {
        private Usuario _usuario;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AbmEmpresaForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        public void mostrarPantallaUsuario(Usuario usuario)
        {
            _usuario = usuario;
            
            var listaBotones = this.Controls.OfType<Button>();
            List<Funcionalidad> lstFunc = CapaADO.DAOFuncionalidades.getRolFunc(usuario.RolActivo);
            List<string> lstNomFunc = new List<string>();
            foreach (Funcionalidad f in lstFunc) {
                lstNomFunc.Add(f.getNombreFuncionalidad());
            }
            foreach (var btn in listaBotones)
            {
                string btnText = btn.Text;
                bool visibilidad = lstNomFunc.Contains(btnText) ? true : false;
                btn.Visible = visibilidad;
            }

            logoutToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Visible = false;

            this.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new LoginForm(new MenuPrincipal()).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("¿Está seguro que desea cerrar sesión?","FRBA Commerce v1.0",MessageBoxButtons.YesNo);

            if (dr != DialogResult.Yes) return;
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
            Logout();
        }

        private void Logout()
        {
            var lista = Controls.OfType<Button>();
            foreach (var button in lista)
            {
                button.Visible = false;
            }
        }

        private void btnComprarOfertar_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new Comprar_Ofertar.ComprarOfertar(this,Globals.userID), this);
        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            var frmListPub = new VerPublicaciones(this);
            //frmGenPub.publicacion = DAO.ADOPublicacion.getPublicacion(1);
            FormHelper.mostrarNuevaVentana(frmListPub, this);
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AbmClienteForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void btbABMRol_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AbmRolForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            var frmFacturar = new Facturar_Publicaciones.frmFacturarPublicaciones(this);
            FormHelper.mostrarNuevaVentana(frmFacturar, this);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            var frmCalificar = new Calificar_Vendedor.Calificar(this, Globals.userID);
            FormHelper.mostrarNuevaVentana(frmCalificar, this);
        }

        private void btnModificarPassword_Click(object sender, EventArgs e)
        {
            var frmManejoUsuarios = new frmManejoUsuarios(this,0);
            FormHelper.mostrarNuevaVentana(frmManejoUsuarios, this);
        }


        private void btnABMVisibilidad_Click(object sender, EventArgs e)
        {
            var frmVis = new Abm_Visibilidad.AbmVisibilidadForm(this);
            FormHelper.mostrarNuevaVentana(frmVis, this);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            var frmHist = new Historial_Cliente.HistorialClienteForm(this,Globals.userID);
            FormHelper.mostrarNuevaVentana(frmHist, this);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            var frmEst = new Listado_Estadistico.ListadosForm(this);
            FormHelper.mostrarNuevaVentana(frmEst, this);
        }

    }
}
