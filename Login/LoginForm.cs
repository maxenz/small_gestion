using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Helpers;
using FrbaCommerce.Model;

namespace FrbaCommerce.Login
{
    public partial class LoginForm : Form
    {
        MenuPrincipal _principal;
        const int IS_CLIENT = 2;

        public LoginForm(MenuPrincipal principal)
        {
            _principal = principal;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login_button.Enabled = false;
        }

        private void Cambios(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void validarCampos()
        {
            var nombreUsuario = tBoxNombreUsuario.Text;
            var password = tBoxPassword.Text;
            var camposAValidar = new List<ICampoAbstracto>
            {
                new Campo("Usuario", nombreUsuario, true, Controller.TipoValidacion.Alfanumerico),
                new Campo("Password", password, true, Controller.TipoValidacion.Alfanumerico)
            };

            try
            {
                Controller.validarCampos(camposAValidar);
                login_button.Enabled = true;
                errorBox.Text = "";
            }
            catch (ValidationException vEx)
            {
                errorBox.Text = vEx.mensaje;
                login_button.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tBoxNombreUsuario.Text;
            string password = tBoxPassword.Text;
            try
            {
                Usuario usuario = DAOUsuario.GetUsuario(nombreUsuario, password);
                var roles = DAORol.getRolesUsuario(usuario.Id);
                if (roles.Rows.Count == 1)
                {
                    usuario.RolActivo = (int) roles.Rows[0]["ID"];
                    MessageBox.Show("Bienvenido " + nombreUsuario);
                    _principal.mostrarPantallaUsuario(usuario);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    var rolesForm = new RolesForm(usuario);
                    if (rolesForm.ShowDialog() == DialogResult.OK)
                    {
                        usuario = rolesForm.Usuario;
                        MessageBox.Show("Bienvenido " + nombreUsuario);
                        _principal.mostrarPantallaUsuario(usuario);
                        DialogResult = DialogResult.OK;
                    }
                }
                
                
            }

            catch (UsuarioNoEncontradoException notFound)
            {
                MessageBox.Show("No existe el usuario " + notFound.getNombreUsuario());
            }

            catch (UsuarioAlcanzoLimiteLoginsException maxLogin)
            {
                MessageBox.Show("El usuario " + maxLogin.getNombreUsuario() +
                                " se encuentra bloqueado por superar la cantidad maxima de logins permitidos.");
            }
            catch (PasswordIncorrectoException)
            {
                MessageBox.Show("Password incorrecto.");
            }
            catch (UsuarioSinRolesAsignadosException noRolEx)
            {
                MessageBox.Show("El usuario " + noRolEx.getNombreUsuario() + " no tiene ningun rol asignado.");
            }
        }

        private bool datosValidos(string username, string password)
        {
            return Controller.stringValido(username) && Controller.stringValido(password);
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tBoxNombreUsuario.Text;
            string password = tBoxPassword.Text;
            new RegistrarUsuarioForm(this,nombreUsuario).Show();
            
        }

    }
}
