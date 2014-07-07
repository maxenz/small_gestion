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

namespace FrbaCommerce.Abm_Empresa
{
    public partial class ModificarEmpresaForm : Form
    {
        private Empresa _empresa;
        private Form _padre;
        private int ID;
        public ModificarEmpresaForm(int id, Form padre)
        {
            InitializeComponent();
            _padre = padre;
            _padre.Enabled = false;
            _empresa = DAOEmpresa.getEmpresa(id);
            ID = id;
            CargarComponentes();
        }

        private void CargarComponentes()
        {
            tbNombreContacto.Text = _empresa.NombreContacto;

            var p = _empresa.Persona;

            tbCalle.Text = p.Domicilio_Calle;
            tbNroCalle.Text = p.Nro_Calle.ToString();
            tbCiudad.Text = p.Ciudad;
            tbCodigoPostal.Text = p.Cod_Postal;
            tbDepartamento.Text = p.Departamento;
            tbEMail.Text = p.Mail;
            tbLocalidad.Text = p.Localidad;
            tbPiso.Text = p.Piso.ToString();
            tbTelefono.Text = p.Telefono;
        }

        private void ModificarEmpresaForm_Load(object sender, EventArgs e)
        {

        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            tbCalle.Text =
            tbNroCalle.Text =
            tbCiudad.Text = 
            tbCodigoPostal.Text = 
            tbDepartamento.Text = 
            tbEMail.Text =
            tbLocalidad.Text = 
            tbNombreContacto.Text = 
            tbPiso.Text = 
            tbTelefono.Text = "";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {

                try
                {
                    DAOEmpresa.UpdateEmpresa(GenerarEmpresa(),ID);
                    MessageBox.Show("Empresa modificada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error." + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error en la validacion de datos. Corroborá que todos los campos ingresados esten llenos con la imformación correcta.");
            }

        }

        private bool Validaciones()
        {
            //TODO
            return true;
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
                Mail = tbEMail.Text,
                Localidad = tbLocalidad.Text,
                Piso = tbPiso.Text,
                Telefono = tbTelefono.Text
            };
            return new Empresa(persona, _empresa.RazonSocial, _empresa.Cuit, tbNombreContacto.Text, _empresa.FechaDeCreacion);

        }

        private void ModificarEmpresaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _padre.Enabled = true;
        }
    }
}
