using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class AbmVisibilidadForm : Form
    {
        private Form _padre;

        public AbmVisibilidadForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AltaVisibilidadForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }
        private void AbmVisibilidadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            var nuevaForma = new FiltrarVisibilidadForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }
    }
}
