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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbNroCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCuil = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.btnAltaEmpresa = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.tbNombreContacto = new System.Windows.Forms.TextBox();
            this.tbRazonSocial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlCliente.SuspendLayout();
            this.pnlEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
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
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(3, 87);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 13);
            this.lblDNI.TabIndex = 88;
            this.lblDNI.Text = "Documento";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Numero:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "Cod postal:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "CUIL";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(114, 134);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(89, 20);
            this.tbCalle.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Departamento:";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(114, 109);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(89, 20);
            this.tbLocalidad.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Ciudad";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(114, 83);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(89, 20);
            this.tbCiudad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Localidad";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(281, 109);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(44, 20);
            this.tbCodigoPostal.TabIndex = 5;
            this.tbCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Piso:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(114, 213);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(89, 20);
            this.tbTelefono.TabIndex = 11;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Calle";
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(114, 187);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(89, 20);
            this.tbEMail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Telefono";
            // 
            // tbCuil
            // 
            this.tbCuil.Location = new System.Drawing.Point(82, 57);
            this.tbCuil.Name = "tbCuil";
            this.tbCuil.Size = new System.Drawing.Size(89, 20);
            this.tbCuil.TabIndex = 67;
            this.tbCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "E-Mail";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(82, 31);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Apellido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "Nombre";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.label16);
            this.pnlCliente.Controls.Add(this.label15);
            this.pnlCliente.Controls.Add(this.cbTipoDoc);
            this.pnlCliente.Controls.Add(this.tbNombre);
            this.pnlCliente.Controls.Add(this.tbApellido);
            this.pnlCliente.Controls.Add(this.tbDni);
            this.pnlCliente.Controls.Add(this.tbCuil);
            this.pnlCliente.Controls.Add(this.lblDNI);
            this.pnlCliente.Controls.Add(this.dtpFechaNac);
            this.pnlCliente.Controls.Add(this.btnAltaCliente);
            this.pnlCliente.Controls.Add(this.label13);
            this.pnlCliente.Controls.Add(this.label8);
            this.pnlCliente.Location = new System.Drawing.Point(331, 79);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(430, 184);
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
            this.pnlEmpresa.Controls.Add(this.label28);
            this.pnlEmpresa.Controls.Add(this.label29);
            this.pnlEmpresa.Controls.Add(this.label20);
            this.pnlEmpresa.Location = new System.Drawing.Point(331, 68);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(287, 195);
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
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 13);
            this.label28.TabIndex = 32;
            this.label28.Text = "Nombre de contacto";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 13);
            this.label29.TabIndex = 31;
            this.label29.Text = "Razon social";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "CUIT";
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
            // RegistrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 279);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlEmpresa);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.tbNroCalle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPiso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDepartamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCodigoPostal);
            this.Name = "RegistrarUsuarioForm";
            this.Text = "RegistrarUsuarioForm";
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox tbNroCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDepartamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCuil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.TextBox tbCuit;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.TextBox tbNombreContacto;
        private System.Windows.Forms.TextBox tbRazonSocial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAltaEmpresa;
        private System.Windows.Forms.Button btnLimpiar;
    }
}