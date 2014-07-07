namespace FrbaCommerce.Login
{
    partial class RegistrarUsuarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDocumentoCliente = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbNroCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.lblDepto = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbCuil = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.btnAltaEmpresa = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.tbNombreContacto = new System.Windows.Forms.TextBox();
            this.tbRazonSocial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblNombreRazonSocial = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlCliente.SuspendLayout();
            this.pnlEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(35, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsuario.Location = new System.Drawing.Point(114, 29);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(89, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.Location = new System.Drawing.Point(114, 55);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(89, 20);
            this.tbPass.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 58);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña:";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(6, 147);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(81, 34);
            this.btnAltaCliente.TabIndex = 5;
            this.btnAltaCliente.Text = "Registrarse";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(423, 29);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(99, 21);
            this.cbTipoUsuario.TabIndex = 69;
            this.cbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbTipoUsuario_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de usuario:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(196, 82);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(103, 21);
            this.cbTipoDoc.TabIndex = 90;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(82, 83);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(89, 20);
            this.tbDni.TabIndex = 89;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblDocumentoCliente
            // 
            this.lblDocumentoCliente.AutoSize = true;
            this.lblDocumentoCliente.Location = new System.Drawing.Point(3, 87);
            this.lblDocumentoCliente.Name = "lblDocumentoCliente";
            this.lblDocumentoCliente.Size = new System.Drawing.Size(62, 13);
            this.lblDocumentoCliente.TabIndex = 88;
            this.lblDocumentoCliente.Text = "Documento";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(299, 4);
            this.dtpFechaNac.MaxDate = new System.DateTime(1996, 6, 18, 0, 0, 0, 0);
            this.dtpFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaNac.ShowUpDown = true;
            this.dtpFechaNac.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaNac.TabIndex = 87;
            this.dtpFechaNac.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // tbNroCalle
            // 
            this.tbNroCalle.Location = new System.Drawing.Point(281, 134);
            this.tbNroCalle.Name = "tbNroCalle";
            this.tbNroCalle.Size = new System.Drawing.Size(44, 20);
            this.tbNroCalle.TabIndex = 7;
            this.tbNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(228, 138);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 85;
            this.lblNumero.Text = "Numero:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(215, 112);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(60, 13);
            this.lblCodPostal.TabIndex = 84;
            this.lblCodPostal.Text = "Cod postal:";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Location = new System.Drawing.Point(114, 161);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(89, 20);
            this.tbDepartamento.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "Fecha de nacimiento";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(281, 158);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(44, 20);
            this.tbPiso.TabIndex = 9;
            this.tbPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Location = new System.Drawing.Point(3, 59);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(31, 13);
            this.lblCUIL.TabIndex = 80;
            this.lblCUIL.Text = "CUIL";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(114, 134);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(89, 20);
            this.tbCalle.TabIndex = 6;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(35, 164);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(77, 13);
            this.lblDepto.TabIndex = 78;
            this.lblDepto.Text = "Departamento:";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(114, 109);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(89, 20);
            this.tbLocalidad.TabIndex = 4;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(35, 86);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 76;
            this.lblCiudad.Text = "Ciudad";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(114, 83);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(89, 20);
            this.tbCiudad.TabIndex = 3;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(35, 112);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 74;
            this.lblLocalidad.Text = "Localidad";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(281, 109);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(44, 20);
            this.tbCodigoPostal.TabIndex = 5;
            this.tbCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(245, 161);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 72;
            this.lblPiso.Text = "Piso:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(114, 213);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(89, 20);
            this.tbTelefono.TabIndex = 11;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(35, 138);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 70;
            this.lblCalle.Text = "Calle";
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(114, 187);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(89, 20);
            this.tbEMail.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(35, 216);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 68;
            this.lblTelefono.Text = "Telefono";
            // 
            // tbCuil
            // 
            this.tbCuil.Location = new System.Drawing.Point(82, 57);
            this.tbCuil.Name = "tbCuil";
            this.tbCuil.Size = new System.Drawing.Size(89, 20);
            this.tbCuil.TabIndex = 67;
            this.tbCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "E-Mail";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(82, 33);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(89, 20);
            this.tbApellido.TabIndex = 65;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(82, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(89, 20);
            this.tbNombre.TabIndex = 64;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(3, 34);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoCliente.TabIndex = 63;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(3, 7);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 62;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblNombreCliente);
            this.pnlCliente.Controls.Add(this.lblApellidoCliente);
            this.pnlCliente.Controls.Add(this.cbTipoDoc);
            this.pnlCliente.Controls.Add(this.tbNombre);
            this.pnlCliente.Controls.Add(this.tbApellido);
            this.pnlCliente.Controls.Add(this.tbDni);
            this.pnlCliente.Controls.Add(this.tbCuil);
            this.pnlCliente.Controls.Add(this.lblDocumentoCliente);
            this.pnlCliente.Controls.Add(this.dtpFechaNac);
            this.pnlCliente.Controls.Add(this.btnAltaCliente);
            this.pnlCliente.Controls.Add(this.label13);
            this.pnlCliente.Controls.Add(this.lblCUIL);
            this.pnlCliente.Location = new System.Drawing.Point(382, 79);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(353, 184);
            this.pnlCliente.TabIndex = 91;
            this.pnlCliente.Visible = false;
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.Controls.Add(this.btnAltaEmpresa);
            this.pnlEmpresa.Controls.Add(this.btnToday);
            this.pnlEmpresa.Controls.Add(this.tbCuit);
            this.pnlEmpresa.Controls.Add(this.dtpFechaCreacion);
            this.pnlEmpresa.Controls.Add(this.tbNombreContacto);
            this.pnlEmpresa.Controls.Add(this.tbRazonSocial);
            this.pnlEmpresa.Controls.Add(this.label19);
            this.pnlEmpresa.Controls.Add(this.lblNombreRazonSocial);
            this.pnlEmpresa.Controls.Add(this.lblRazonSocial);
            this.pnlEmpresa.Controls.Add(this.lblCUIT);
            this.pnlEmpresa.Location = new System.Drawing.Point(331, 68);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(329, 195);
            this.pnlEmpresa.TabIndex = 92;
            this.pnlEmpresa.Visible = false;
            // 
            // btnAltaEmpresa
            // 
            this.btnAltaEmpresa.Location = new System.Drawing.Point(6, 158);
            this.btnAltaEmpresa.Name = "btnAltaEmpresa";
            this.btnAltaEmpresa.Size = new System.Drawing.Size(81, 34);
            this.btnAltaEmpresa.TabIndex = 56;
            this.btnAltaEmpresa.Text = "Registrarse";
            this.btnAltaEmpresa.UseVisualStyleBackColor = true;
            this.btnAltaEmpresa.Click += new System.EventHandler(this.btnAltaEmpresa_Click);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnToday.Location = new System.Drawing.Point(209, 95);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(34, 20);
            this.btnToday.TabIndex = 55;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // tbCuit
            // 
            this.tbCuit.Location = new System.Drawing.Point(108, 67);
            this.tbCuit.Name = "tbCuit";
            this.tbCuit.Size = new System.Drawing.Size(135, 20);
            this.tbCuit.TabIndex = 36;
            this.tbCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(108, 95);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaCreacion.TabIndex = 54;
            // 
            // tbNombreContacto
            // 
            this.tbNombreContacto.Location = new System.Drawing.Point(108, 41);
            this.tbNombreContacto.Name = "tbNombreContacto";
            this.tbNombreContacto.Size = new System.Drawing.Size(135, 20);
            this.tbNombreContacto.TabIndex = 34;
            // 
            // tbRazonSocial
            // 
            this.tbRazonSocial.Location = new System.Drawing.Point(108, 14);
            this.tbRazonSocial.Name = "tbRazonSocial";
            this.tbRazonSocial.Size = new System.Drawing.Size(135, 20);
            this.tbRazonSocial.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "Fecha de creacion";
            // 
            // lblNombreRazonSocial
            // 
            this.lblNombreRazonSocial.AutoSize = true;
            this.lblNombreRazonSocial.Location = new System.Drawing.Point(3, 45);
            this.lblNombreRazonSocial.Name = "lblNombreRazonSocial";
            this.lblNombreRazonSocial.Size = new System.Drawing.Size(104, 13);
            this.lblNombreRazonSocial.TabIndex = 32;
            this.lblNombreRazonSocial.Text = "Nombre de contacto";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(3, 18);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 31;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(3, 71);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 49;
            this.lblCUIT.Text = "CUIT";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(231, 226);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 34);
            this.btnLimpiar.TabIndex = 93;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 279);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlEmpresa);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.tbNroCalle);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.tbPiso);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.tbDepartamento);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.tbCodigoPostal);
            this.Name = "RegistrarUsuarioForm";
            this.Text = "RegistrarUsuarioForm";
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDocumentoCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox tbNroCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox tbDepartamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbCuil;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.TextBox tbCuit;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.TextBox tbNombreContacto;
        private System.Windows.Forms.TextBox tbRazonSocial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblNombreRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Button btnAltaEmpresa;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}