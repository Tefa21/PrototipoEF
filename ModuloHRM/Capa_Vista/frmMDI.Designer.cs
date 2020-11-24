namespace Capa_Vista
{
    partial class frmMDI
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
            this.mspMDI = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartamentoMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTiposDeCompetenciasMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFaltasMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarFaltaMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesarrolloProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarCompetenciasProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesarrolloReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompetenciasReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.TsmiCambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMDI
            // 
            this.mspMDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))));
            this.mspMDI.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mspMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiMantenimientos,
            this.tsmiProcesos,
            this.tsmiHerramientas,
            this.tsmiReportes,
            this.tsmiAyuda});
            this.mspMDI.Location = new System.Drawing.Point(0, 0);
            this.mspMDI.Name = "mspMDI";
            this.mspMDI.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mspMDI.Size = new System.Drawing.Size(731, 24);
            this.mspMDI.TabIndex = 0;
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion});
            this.tsmiInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(48, 20);
            this.tsmiInicio.Text = "Inicio";
            this.tsmiInicio.ToolTipText = "Opciones de Sesión";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(150, 22);
            this.tsmiCerrarSesion.Text = "Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiMantenimientos
            // 
            this.tsmiMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDepartamentoMantenimientos,
            this.tsmiTiposDeCompetenciasMantenimientos,
            this.tsmiFaltasMantenimientos});
            this.tsmiMantenimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiMantenimientos.Name = "tsmiMantenimientos";
            this.tsmiMantenimientos.Size = new System.Drawing.Size(108, 20);
            this.tsmiMantenimientos.Text = "Mantenimientos";
            this.tsmiMantenimientos.ToolTipText = "Mantenimientos del Módulo";
            // 
            // tsmiDepartamentoMantenimientos
            // 
            this.tsmiDepartamentoMantenimientos.Name = "tsmiDepartamentoMantenimientos";
            this.tsmiDepartamentoMantenimientos.Size = new System.Drawing.Size(243, 22);
            this.tsmiDepartamentoMantenimientos.Text = "Departamentos Empresariales";
            this.tsmiDepartamentoMantenimientos.Click += new System.EventHandler(this.tsmiDepartamentoMantenimientos_Click);
            // 
            // tsmiTiposDeCompetenciasMantenimientos
            // 
            this.tsmiTiposDeCompetenciasMantenimientos.Name = "tsmiTiposDeCompetenciasMantenimientos";
            this.tsmiTiposDeCompetenciasMantenimientos.Size = new System.Drawing.Size(243, 22);
            this.tsmiTiposDeCompetenciasMantenimientos.Text = "Tipos De Competencias";
            this.tsmiTiposDeCompetenciasMantenimientos.Click += new System.EventHandler(this.tsmiTiposDeCompetenciasMantenimientos_Click);
            // 
            // tsmiFaltasMantenimientos
            // 
            this.tsmiFaltasMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarFaltaMantenimientos});
            this.tsmiFaltasMantenimientos.Name = "tsmiFaltasMantenimientos";
            this.tsmiFaltasMantenimientos.Size = new System.Drawing.Size(243, 22);
            this.tsmiFaltasMantenimientos.Text = "Faltas";
            // 
            // tsmiIngresarFaltaMantenimientos
            // 
            this.tsmiIngresarFaltaMantenimientos.Name = "tsmiIngresarFaltaMantenimientos";
            this.tsmiIngresarFaltaMantenimientos.Size = new System.Drawing.Size(150, 22);
            this.tsmiIngresarFaltaMantenimientos.Text = "Ingresar Falta";
            this.tsmiIngresarFaltaMantenimientos.Click += new System.EventHandler(this.tsmiIngresarFaltaMantenimientos_Click);
            // 
            // tsmiProcesos
            // 
            this.tsmiProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDesarrolloProceso});
            this.tsmiProcesos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiProcesos.Name = "tsmiProcesos";
            this.tsmiProcesos.Size = new System.Drawing.Size(70, 20);
            this.tsmiProcesos.Text = "Procesos";
            // 
            // tsmiDesarrolloProceso
            // 
            this.tsmiDesarrolloProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarCompetenciasProceso});
            this.tsmiDesarrolloProceso.Name = "tsmiDesarrolloProceso";
            this.tsmiDesarrolloProceso.Size = new System.Drawing.Size(132, 22);
            this.tsmiDesarrolloProceso.Text = "Desarrollo";
            // 
            // tsmiIngresarCompetenciasProceso
            // 
            this.tsmiIngresarCompetenciasProceso.Name = "tsmiIngresarCompetenciasProceso";
            this.tsmiIngresarCompetenciasProceso.Size = new System.Drawing.Size(204, 22);
            this.tsmiIngresarCompetenciasProceso.Text = "Ingresar Competencias";
            this.tsmiIngresarCompetenciasProceso.Click += new System.EventHandler(this.tsmiIngresarCompetenciasProceso_Click);
            // 
            // tsmiHerramientas
            // 
            this.tsmiHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCambioDeContraseñaToolStripMenuItem,
            this.bitácoraToolStripMenuItem});
            this.tsmiHerramientas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiHerramientas.Name = "tsmiHerramientas";
            this.tsmiHerramientas.Size = new System.Drawing.Size(94, 20);
            this.tsmiHerramientas.Text = "Herramientas";
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDesarrolloReporte});
            this.tsmiReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(70, 20);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiDesarrolloReporte
            // 
            this.tsmiDesarrolloReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompetenciasReporte});
            this.tsmiDesarrolloReporte.Name = "tsmiDesarrolloReporte";
            this.tsmiDesarrolloReporte.Size = new System.Drawing.Size(132, 22);
            this.tsmiDesarrolloReporte.Text = "Desarrollo";
            // 
            // tsmiCompetenciasReporte
            // 
            this.tsmiCompetenciasReporte.Name = "tsmiCompetenciasReporte";
            this.tsmiCompetenciasReporte.Size = new System.Drawing.Size(154, 22);
            this.tsmiCompetenciasReporte.Text = "Competencias";
            this.tsmiCompetenciasReporte.Click += new System.EventHandler(this.tsmiCompetenciasReporte_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(55, 20);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(0, 410);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(731, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 24);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(731, 406);
            this.pnlContenedor.TabIndex = 1;
            // 
            // TsmiCambioDeContraseñaToolStripMenuItem
            // 
            this.TsmiCambioDeContraseñaToolStripMenuItem.Name = "TsmiCambioDeContraseñaToolStripMenuItem";
            this.TsmiCambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.TsmiCambioDeContraseñaToolStripMenuItem.Text = "Cambio de Contraseña";
            this.TsmiCambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.TsmiCambioDeContraseñaToolStripMenuItem_Click);
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 430);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.mspMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMDI;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "301 - Módulo de Recursos Humanos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.mspMDI.ResumeLayout(false);
            this.mspMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcesos;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiHerramientas;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesarrolloProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarCompetenciasProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesarrolloReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompetenciasReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartamentoMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiTiposDeCompetenciasMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiFaltasMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarFaltaMantenimientos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ToolStripMenuItem TsmiCambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
    }
}