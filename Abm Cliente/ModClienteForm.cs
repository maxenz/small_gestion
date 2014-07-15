using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Helpers;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ModClienteForm : Form
    {
        CleanFormHelper cfh = new CleanFormHelper();
        private Cliente _cliente;
        private FiltrarClienteForm _padre;
        private int ID;
        public ModClienteForm(int id, FiltrarClienteForm padre )
        {
            InitializeComponent();
            _padre = padre;
            _cliente = DAOCliente.getCliente(id);
            ID = id;
            cbTipoDoc.DisplayMember = "Descripcion";
            cbTipoDoc.ValueMember = "ID";
            cbTipoDoc.DataSource = DAOCliente.TiposDocumento();

            CargarComponentes();
        }

        private void CargarComponentes()
        {
            var p = _cliente.Persona;

            tbCalle.Text = p.Domicilio_Calle;
            tbNroCalle.Text = p.Nro_Calle.ToString();
            tbCiudad.Text = p.Ciudad;
            tbCodigoPostal.Text = p.Cod_Postal;
            tbDepartamento.Text = p.Departamento;
            tbEMail.Text = p.Mail;
            tbLocalidad.Text = p.Localidad;
            tbPiso.Text = p.Piso.ToString();
            tbTelefono.Text = p.Telefono;

            tbNombre.Text = _cliente.Nombre;
            tbApellido.Text = _cliente.Apellido;
            tbDni.Text = _cliente.Documento;
            tbCuil.Text = _cliente.Cuil;
            cbTipoDoc.SelectedValue = _cliente.TipoDoc;
            dtpFechaNac.Text = _cliente.FechaDeNacimiento;
            
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!clienteValidado()) return;
            if (!Validaciones()) return;

            try
            {
                DAOCliente.UpdateCliente(GenerarCliente(), ID);
                MessageBox.Show("Cliente modificado correctamente.");
                _padre.CargarGrid();
                this.Hide();
                FormHelper.volverAPadre(_padre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private Cliente GenerarCliente()
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
            return new Cliente(persona, tbNombre.Text, tbApellido.Text, tbDni.Text, tbCuil.Text, Convert.ToInt32(cbTipoDoc.SelectedValue), dtpFechaNac.Text, tbTelefono.Text);
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarDni() != null) listaDeErrores.Add(ValidarDni());
            if (ValidarTelefono() != null) listaDeErrores.Add(ValidarTelefono());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarDni()
        {
            return (DAOCliente.existeDni(tbDni.Text, Convert.ToInt32(cbTipoDoc.SelectedValue)) && tbDni.Text != _cliente.Documento) ? new Error("El documento ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Error ValidarTelefono()
        {
            return (DAOCliente.existeTelefono(tbTelefono.Text) && tbTelefono.Text != _cliente.Telefono) ? new Error("El telefono ingresado ya está asignado a un usuario registrado.") : null;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
            dtpFechaNac.Value = new DateTime(1996, 1, 1);
        }

        private void ModClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void validateTextbox(string texto, string error, ref bool vBool, Label lbl)
        {
            if (texto == "")
            {
                errorProvider1.SetError(lbl, error);
                vBool = false;
            }
        }

        private bool clienteValidado()
        {
            cfh.cleanErrorProviderInLabels(this.Controls, errorProvider1);
            bool vBool = true;

            validateTextbox(tbNombre.Text, "Debe ingresar el nombre", ref vBool, lblNombre);
            validateTextbox(tbApellido.Text, "Debe ingresar el apellido", ref vBool, lblApellido);
            validateTextbox(tbCuil.Text, "Debe ingresar el CUIL", ref vBool, lblCUIL);
            validateTextbox(tbEMail.Text, "Debe ingresar el EMAIL", ref vBool, lblEmail);
            validateTextbox(tbTelefono.Text, "Debe ingresar el Teléfono", ref vBool, lblTelefono);
            validateTextbox(tbCalle.Text, "Debe ingresar la calle", ref vBool, lblCalle);
            validateTextbox(tbNroCalle.Text, "Debe ingresar el nro de la calle", ref vBool, lblNumero);
            validateTextbox(tbDni.Text, "Debe ingresar el nro de documento", ref vBool, lblDNI);

            return vBool;
        }
    }
}
