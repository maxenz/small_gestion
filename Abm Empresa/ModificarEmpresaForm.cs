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

namespace FrbaCommerce.Abm_Empresa
{
    public partial class ModificarEmpresaForm : Form
    {
        CleanFormHelper cfh = new CleanFormHelper();
        private Empresa _empresa;
        private FiltrarEmpresaForm _padre;
        private int ID;
        public ModificarEmpresaForm(int id, FiltrarEmpresaForm padre)
        {
            InitializeComponent();
            _padre = padre;
            _empresa = DAOEmpresa.getEmpresa(id);
            ID = id;
            CargarComponentes();
        }

        private void CargarComponentes()
        {
            tbRazonSocial.Text = _empresa.RazonSocial;

            var p = _empresa.Persona;

            tbCalle.Text = p.Domicilio_Calle;
            tbNroCalle.Text = p.Nro_Calle.ToString();
            tbCiudad.Text = p.Ciudad;
            tbCodigoPostal.Text = p.Cod_Postal;
            tbDepartamento.Text = p.Departamento;
            tbCuit.Text = _empresa.Cuit;
            tbLocalidad.Text = p.Localidad;
            tbPiso.Text = p.Piso.ToString();
            tbTelefono.Text = p.Telefono;
            tbNombreContacto.Text = _empresa.NombreContacto;
            tbEmail.Text = p.Mail;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            tbCalle.Text = "";
            tbNroCalle.Text = "";
            tbCiudad.Text = "";
            tbCodigoPostal.Text = "";
            tbDepartamento.Text = "";
            tbCuit.Text = "";
            tbLocalidad.Text = "";
            tbRazonSocial.Text = "";
            tbPiso.Text = "";
            tbTelefono.Text = "";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!empresaValidada()) return;
            if (!Validaciones()) return;

            try
            {
                Empresa emp = GenerarEmpresa();
                DAOEmpresa.UpdateEmpresa(emp, ID);
                _padre.CargarGrid();
                this.Hide();
                FormHelper.volverAPadre(_padre);
                MessageBox.Show("Empresa modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }

        }

        private bool Validaciones()
        {
            try
            {
                if (tbCuit.Text.Count() > 50) throw new Exception("Cuit demasiado largo");
                if (DAOEmpresa.existeCuit(tbCuit.Text) && tbCuit.Text != _empresa.Cuit) throw new Exception("Cuit existente");
                if (DAOEmpresa.existeRazonSocial(tbRazonSocial.Text) && tbRazonSocial.Text != _empresa.RazonSocial) throw new Exception("Razón Social existente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private void validateTextbox(string texto, string error, ref bool vBool, Label lbl)
        {

            if (texto == "")
            {
                errorProvider1.SetError(lbl, error);
                vBool = false;
            }
        }

        private bool empresaValidada()
        {
            cfh.cleanErrorProviderInLabels(this.Controls, errorProvider1);
            bool vBool = true;

            validateTextbox(tbRazonSocial.Text, "Debe ingresar la razón social", ref vBool, lblRazonSocial);
            validateTextbox(tbRazonSocial.Text, "Debe ingresar el apellido", ref vBool, lblNomContacto);
            validateTextbox(tbCuit.Text, "Debe ingresar el CUIT", ref vBool, lblCUIT);
            validateTextbox(tbCuit.Text, "Debe ingresar el EMAIL", ref vBool, lblEmail);
            validateTextbox(tbTelefono.Text, "Debe ingresar el Teléfono", ref vBool, lblTelefono);
            validateTextbox(tbCalle.Text, "Debe ingresar la calle", ref vBool, lblCalle);
            validateTextbox(tbNroCalle.Text, "Debe ingresar el nro de la calle", ref vBool, lblNumero);

            return vBool;
        }

        private Empresa GenerarEmpresa()
        {
            var persona = new Persona
            {
                Domicilio_Calle = tbCalle.Text,
                Nro_Calle = Convert.ToInt32(tbNroCalle.Text),
                Ciudad = tbCiudad.Text,
                Cod_Postal = tbCodigoPostal.Text,
                Departamento = tbDepartamento.Text,
                Mail = tbCuit.Text,
                Localidad = tbLocalidad.Text,
                Piso = tbPiso.Text,
                Telefono = tbTelefono.Text
            };
            return new Empresa(persona, _empresa.RazonSocial, _empresa.Cuit, tbRazonSocial.Text, _empresa.FechaDeCreacion);

        }

        private void ModificarEmpresaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }
    }
}
