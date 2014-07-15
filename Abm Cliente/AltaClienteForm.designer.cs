namespace FrbaCommerce.Abm_Cliente
{
    partial class AltaClienteForm
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaCliente_FormClosed);
            this.components = new System.ComponentModel.Container();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.tbNroCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.lblFecNac = new System.Windows.Forms.Label();
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bAceptar.Location = new System.Drawing.Point(288, 207);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 28;
            this.bAceptar.Text = "Guardar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(192, 207);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 27;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // tbNroCalle
            // 
            this.tbNroCalle.Location = new System.Drawing.Point(509, 67);
            this.tbNroCalle.Name = "tbNroCalle";
            this.tbNroCalle.Size = new System.Drawing.Size(29, 20);
            this.tbNroCalle.TabIndex = 57;
            this.tbNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(456, 71);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 56;
            this.lblNumero.Text = "Numero:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(443, 45);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(60, 13);
            this.lblCodPostal.TabIndex = 53;
            this.lblCodPostal.Text = "Cod postal:";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Location = new System.Drawing.Point(342, 94);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(89, 20);
            this.tbDepartamento.TabIndex = 52;
            this.tbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Location = new System.Drawing.Point(236, 123);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(106, 13);
            this.lblFecNac.TabIndex = 51;
            this.lblFecNac.Text = "Fecha de nacimiento";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(509, 91);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(29, 20);
            this.tbPiso.TabIndex = 50;
            this.tbPiso.TextChanged += new System.EventHandler(this.tbPiso_TextChanged);
            this.tbPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Location = new System.Drawing.Point(12, 70);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(31, 13);
            this.lblCUIL.TabIndex = 49;
            this.lblCUIL.Text = "CUIL";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(342, 67);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(89, 20);
            this.tbCalle.TabIndex = 48;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(236, 97);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(77, 13);
            this.lblDepto.TabIndex = 47;
            this.lblDepto.Text = "Departamento:";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(342, 42);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(89, 20);
            this.tbLocalidad.TabIndex = 46;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(236, 19);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 45;
            this.lblCiudad.Text = "Ciudad";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(342, 16);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(89, 20);
            this.tbCiudad.TabIndex = 44;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(236, 45);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 43;
            this.lblLocalidad.Text = "Localidad";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(509, 42);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(29, 20);
            this.tbCodigoPostal.TabIndex = 42;
            this.tbCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(473, 94);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 41;
            this.lblPiso.Text = "Piso:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(80, 120);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(116, 20);
            this.tbTelefono.TabIndex = 40;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(236, 71);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 39;
            this.lblCalle.Text = "Calle";
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(80, 94);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(116, 20);
            this.tbEMail.TabIndex = 38;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 123);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 37;
            this.lblTelefono.Text = "Telefono";
            // 
            // tbCuil
            // 
            this.tbCuil.Location = new System.Drawing.Point(80, 68);
            this.tbCuil.Name = "tbCuil";
            this.tbCuil.Size = new System.Drawing.Size(116, 20);
            this.tbCuil.TabIndex = 36;
            this.tbCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "E-Mail";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(80, 42);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(116, 20);
            this.tbApellido.TabIndex = 34;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(80, 15);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(116, 20);
            this.tbNombre.TabIndex = 33;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 45);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 32;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(342, 120);
            this.dtpFechaNac.MaxDate = new System.DateTime(1996, 6, 18, 0, 0, 0, 0);
            this.dtpFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaNac.ShowUpDown = true;
            this.dtpFechaNac.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaNac.TabIndex = 58;
            this.dtpFechaNac.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(80, 148);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(116, 20);
            this.tbDni.TabIndex = 60;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 152);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 13);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "Documento";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(239, 147);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(103, 21);
            this.cbTipoDoc.TabIndex = 61;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AltaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 238);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.tbNroCalle);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.tbDepartamento);
            this.Controls.Add(this.lblFecNac);
            this.Controls.Add(this.tbPiso);
            this.Controls.Add(this.lblCUIL);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.tbCodigoPostal);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.tbCuil);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AltaClienteForm";
            this.Text = "Alta de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.TextBox tbNroCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox tbDepartamento;
        private System.Windows.Forms.Label lblFecNac;
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
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}