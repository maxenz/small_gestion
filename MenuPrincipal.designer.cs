namespace FrbaCommerce
{
    partial class MenuPrincipal
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
            this.btnABMEmpresa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnComprarOfertar = new System.Windows.Forms.Button();
            this.btnGenerarPublicacion = new System.Windows.Forms.Button();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnABMVisibilidad = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btbABMRol = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnModificarPassword = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnABMEmpresa
            // 
            this.btnABMEmpresa.Location = new System.Drawing.Point(40, 128);
            this.btnABMEmpresa.Name = "btnABMEmpresa";
            this.btnABMEmpresa.Size = new System.Drawing.Size(113, 23);
            this.btnABMEmpresa.TabIndex = 0;
            this.btnABMEmpresa.Text = "ABM Empresa";
            this.btnABMEmpresa.UseVisualStyleBackColor = true;
            this.btnABMEmpresa.Visible = false;
            this.btnABMEmpresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginToolStripMenuItem.Image = global::FrbaCommerce.Properties.Resources.Custom_Icon_Design_Pretty_Office_6_Logout;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loginToolStripMenuItem.Text = "Iniciar sesión";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.logoutToolStripMenuItem.Image = global::FrbaCommerce.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.logoutToolStripMenuItem.Text = "Cerrar sesión";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnComprarOfertar
            // 
            this.btnComprarOfertar.Location = new System.Drawing.Point(40, 244);
            this.btnComprarOfertar.Name = "btnComprarOfertar";
            this.btnComprarOfertar.Size = new System.Drawing.Size(113, 23);
            this.btnComprarOfertar.TabIndex = 4;
            this.btnComprarOfertar.Text = "Comprar";
            this.btnComprarOfertar.UseVisualStyleBackColor = true;
            this.btnComprarOfertar.Click += new System.EventHandler(this.btnComprarOfertar_Click);
            // 
            // btnGenerarPublicacion
            // 
            this.btnGenerarPublicacion.Location = new System.Drawing.Point(159, 99);
            this.btnGenerarPublicacion.Name = "btnGenerarPublicacion";
            this.btnGenerarPublicacion.Size = new System.Drawing.Size(162, 23);
            this.btnGenerarPublicacion.TabIndex = 5;
            this.btnGenerarPublicacion.Text = "Generar/Editar Publicacion";
            this.btnGenerarPublicacion.UseVisualStyleBackColor = true;
            this.btnGenerarPublicacion.Click += new System.EventHandler(this.btnGenerarPublicacion_Click);
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Location = new System.Drawing.Point(40, 99);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(113, 23);
            this.btnABMCliente.TabIndex = 6;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Visible = false;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(38, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 32);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "FRBA Commerce";
            // 
            // btnABMVisibilidad
            // 
            this.btnABMVisibilidad.Location = new System.Drawing.Point(40, 215);
            this.btnABMVisibilidad.Name = "btnABMVisibilidad";
            this.btnABMVisibilidad.Size = new System.Drawing.Size(113, 23);
            this.btnABMVisibilidad.TabIndex = 9;
            this.btnABMVisibilidad.Text = "ABM Visibilidad";
            this.btnABMVisibilidad.UseVisualStyleBackColor = true;
            this.btnABMVisibilidad.Click += new System.EventHandler(this.btnABMVisibilidad_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(159, 186);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(113, 23);
            this.btnEstadisticas.TabIndex = 12;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(159, 157);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(113, 23);
            this.btnHistorial.TabIndex = 13;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btbABMRol
            // 
            this.btbABMRol.Location = new System.Drawing.Point(40, 157);
            this.btbABMRol.Name = "btbABMRol";
            this.btbABMRol.Size = new System.Drawing.Size(113, 23);
            this.btbABMRol.TabIndex = 15;
            this.btbABMRol.Text = "ABM Rol";
            this.btbABMRol.UseVisualStyleBackColor = true;
            this.btbABMRol.Click += new System.EventHandler(this.btbABMRol_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(159, 128);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(113, 23);
            this.btnCalificar.TabIndex = 16;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(40, 273);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(113, 23);
            this.btnFacturar.TabIndex = 17;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnModificarPassword
            // 
            this.btnModificarPassword.Location = new System.Drawing.Point(40, 186);
            this.btnModificarPassword.Name = "btnModificarPassword";
            this.btnModificarPassword.Size = new System.Drawing.Size(113, 23);
            this.btnModificarPassword.TabIndex = 8;
            this.btnModificarPassword.Text = "Modificar Password";
            this.btnModificarPassword.UseVisualStyleBackColor = true;
            this.btnModificarPassword.Click += new System.EventHandler(this.btnModificarPassword_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 321);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.btbABMRol);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnABMVisibilidad);
            this.Controls.Add(this.btnModificarPassword);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnABMCliente);
            this.Controls.Add(this.btnABMEmpresa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGenerarPublicacion);
            this.Controls.Add(this.btnComprarOfertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBA Commerce v1.0";
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMEmpresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnComprarOfertar;
        private System.Windows.Forms.Button btnGenerarPublicacion;
        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnABMVisibilidad;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btbABMRol;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnModificarPassword;
    }
}

