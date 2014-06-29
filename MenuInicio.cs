﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;
using FrbaCommerce.Comprar_Ofertar;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Gestion_de_Preguntas;
using FrbaCommerce.Modelo;
using FrbaCommerce.Facturar_Publicaciones;
using FrbaCommerce.Calificar_Vendedor;
using FrbaCommerce.Listado_Estadistico;
using FrbaCommerce.Historial_Cliente;
using FrbaCommerce.Editar_Publicacion;


namespace FrbaCommerce
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }
        
        private void btnComprarOfertar_Click_1(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new ComprarOfertarForm(this, 84), this);
        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            frmGenerarPublicacion frmGenPub = new frmGenerarPublicacion(this);
            //DataTable dtPrueba = DAO.ADOPublicacion.getPublicacion(12353);
            //frmGenPub.publicacion = DAO.ADOPublicacion.getPublicacion(68386);
            //frmGenPub.publicacion.ID_Tipo_Publicacion = 1;
            //frmGenPub.publicacion.ID_Estado = 1;
            FormHelper.mostrarNuevaVentana(frmGenPub, this);


        }

        private void btnResponderPreguntas_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new ResponderPreguntasForm(this, 84), this);
        }

        private void btnVerRespuestas_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new VerRespuestasForm(this, 1), this);
        }

        private void btnFacturarPublicaciones_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new frmFacturarPublicaciones(this), this);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new Calificar(this,37), this);          
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new ListadosForm(this), this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new HistorialClienteForm(this, 5), this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new SeleccionPublicacionForm(this, 5), this);
        }
    }
}
