namespace Capa_Vista.Vista_Desarrollo
{
    partial class frmCompetencias
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
            this.gbxDatosCompetencia = new System.Windows.Forms.GroupBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.gbxRemoverCompetencia = new System.Windows.Forms.GroupBox();
            this.lblIDCompetencia = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtIDCompetencia = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.clmIDCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.gbxCompetencias = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbxDatosCompetencia.SuspendLayout();
            this.gbxRemoverCompetencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.gbxCompetencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosCompetencia
            // 
            this.gbxDatosCompetencia.Controls.Add(this.btnListado);
            this.gbxDatosCompetencia.Controls.Add(this.gbxRemoverCompetencia);
            this.gbxDatosCompetencia.Controls.Add(this.btnIngreso);
            this.gbxDatosCompetencia.Controls.Add(this.lblFechaFin);
            this.gbxDatosCompetencia.Controls.Add(this.dtpFechaFin);
            this.gbxDatosCompetencia.Controls.Add(this.lblFechaInicio);
            this.gbxDatosCompetencia.Controls.Add(this.dtpFechaInicio);
            this.gbxDatosCompetencia.Controls.Add(this.lblTitulo);
            this.gbxDatosCompetencia.Controls.Add(this.txtIDEmpleado);
            this.gbxDatosCompetencia.Controls.Add(this.dgvCompetencias);
            this.gbxDatosCompetencia.Controls.Add(this.lblIDEmpleado);
            this.gbxDatosCompetencia.Controls.Add(this.gbxCompetencias);
            this.gbxDatosCompetencia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosCompetencia.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosCompetencia.Name = "gbxDatosCompetencia";
            this.gbxDatosCompetencia.Size = new System.Drawing.Size(1256, 451);
            this.gbxDatosCompetencia.TabIndex = 5;
            this.gbxDatosCompetencia.TabStop = false;
            this.gbxDatosCompetencia.Text = "Datos De Las Competencias Del Empleado";
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(56, 34);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(123, 43);
            this.btnListado.TabIndex = 10;
            this.btnListado.Text = "Listado de Empleados";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // gbxRemoverCompetencia
            // 
            this.gbxRemoverCompetencia.Controls.Add(this.lblIDCompetencia);
            this.gbxRemoverCompetencia.Controls.Add(this.btnRemover);
            this.gbxRemoverCompetencia.Controls.Add(this.txtIDCompetencia);
            this.gbxRemoverCompetencia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRemoverCompetencia.Location = new System.Drawing.Point(393, 187);
            this.gbxRemoverCompetencia.Name = "gbxRemoverCompetencia";
            this.gbxRemoverCompetencia.Size = new System.Drawing.Size(221, 246);
            this.gbxRemoverCompetencia.TabIndex = 5;
            this.gbxRemoverCompetencia.TabStop = false;
            this.gbxRemoverCompetencia.Text = "Remover Competencia";
            // 
            // lblIDCompetencia
            // 
            this.lblIDCompetencia.AutoSize = true;
            this.lblIDCompetencia.Location = new System.Drawing.Point(58, 62);
            this.lblIDCompetencia.Name = "lblIDCompetencia";
            this.lblIDCompetencia.Size = new System.Drawing.Size(110, 15);
            this.lblIDCompetencia.TabIndex = 3;
            this.lblIDCompetencia.Text = "ID Competencia";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(46, 178);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(138, 36);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "REMOVER COMPETENCIA";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtIDCompetencia
            // 
            this.txtIDCompetencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDCompetencia.Location = new System.Drawing.Point(30, 85);
            this.txtIDCompetencia.Name = "txtIDCompetencia";
            this.txtIDCompetencia.Size = new System.Drawing.Size(164, 23);
            this.txtIDCompetencia.TabIndex = 2;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(731, 43);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(192, 23);
            this.btnIngreso.TabIndex = 9;
            this.btnIngreso.Text = "Ingresar Desarrollo";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(728, 88);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(87, 15);
            this.lblFechaFin.TabIndex = 8;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFechaFin.Location = new System.Drawing.Point(631, 113);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(260, 23);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(386, 88);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(103, 15);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFechaInicio.Location = new System.Drawing.Point(314, 113);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(260, 23);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(902, 158);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 18);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Competencias Ingresadas";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDEmpleado.Location = new System.Drawing.Point(483, 45);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(214, 23);
            this.txtIDEmpleado.TabIndex = 1;
            this.txtIDEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDCompetencia,
            this.clmCompetencia,
            this.clmResultado});
            this.dgvCompetencias.Location = new System.Drawing.Point(745, 187);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.RowHeadersVisible = false;
            this.dgvCompetencias.Size = new System.Drawing.Size(481, 246);
            this.dgvCompetencias.TabIndex = 3;
            // 
            // clmIDCompetencia
            // 
            this.clmIDCompetencia.HeaderText = "ID Competencia";
            this.clmIDCompetencia.Name = "clmIDCompetencia";
            this.clmIDCompetencia.ReadOnly = true;
            // 
            // clmCompetencia
            // 
            this.clmCompetencia.HeaderText = "Competencia";
            this.clmCompetencia.Name = "clmCompetencia";
            this.clmCompetencia.ReadOnly = true;
            // 
            // clmResultado
            // 
            this.clmResultado.HeaderText = "Resultado";
            this.clmResultado.Name = "clmResultado";
            this.clmResultado.ReadOnly = true;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEmpleado.Location = new System.Drawing.Point(377, 48);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(90, 15);
            this.lblIDEmpleado.TabIndex = 0;
            this.lblIDEmpleado.Text = "ID Empleado";
            // 
            // gbxCompetencias
            // 
            this.gbxCompetencias.Controls.Add(this.btnIngresar);
            this.gbxCompetencias.Controls.Add(this.lblCompetencia);
            this.gbxCompetencias.Controls.Add(this.txtResultado);
            this.gbxCompetencias.Controls.Add(this.cmbCompetencias);
            this.gbxCompetencias.Controls.Add(this.lblResultado);
            this.gbxCompetencias.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCompetencias.Location = new System.Drawing.Point(40, 187);
            this.gbxCompetencias.Name = "gbxCompetencias";
            this.gbxCompetencias.Size = new System.Drawing.Size(280, 246);
            this.gbxCompetencias.TabIndex = 2;
            this.gbxCompetencias.TabStop = false;
            this.gbxCompetencias.Text = "Ingreso Competencia";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(66, 178);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(138, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR COMPETENCIA";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(86, 36);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(99, 15);
            this.lblCompetencia.TabIndex = 3;
            this.lblCompetencia.Text = "Competencias";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultado.Location = new System.Drawing.Point(21, 113);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(230, 23);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCompetencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(21, 54);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(230, 23);
            this.cmbCompetencias.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(98, 95);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(71, 15);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // frmCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1280, 475);
            this.Controls.Add(this.gbxDatosCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompetencias";
            this.Text = "306 - Competencias";
            this.Load += new System.EventHandler(this.frmCompetencias_Load);
            this.gbxDatosCompetencia.ResumeLayout(false);
            this.gbxDatosCompetencia.PerformLayout();
            this.gbxRemoverCompetencia.ResumeLayout(false);
            this.gbxRemoverCompetencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.gbxCompetencias.ResumeLayout(false);
            this.gbxCompetencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosCompetencia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.GroupBox gbxCompetencias;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResultado;
        private System.Windows.Forms.GroupBox gbxRemoverCompetencia;
        private System.Windows.Forms.Label lblIDCompetencia;
        private System.Windows.Forms.TextBox txtIDCompetencia;
        private System.Windows.Forms.Button btnListado;
    }
}