namespace Capa_Vista.Vista_Mantenimientos.Tipo_Competencia
{
    partial class frmTipoCompetencia
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
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.lblIDCompetencia = new System.Windows.Forms.Label();
            this.NavegadorCompetencias = new CapaVistaNavegador.Navegador();
            this.txtIDCompetencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnInactivo.Location = new System.Drawing.Point(268, 325);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(77, 19);
            this.rbtnInactivo.TabIndex = 40;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            this.rbtnInactivo.CheckedChanged += new System.EventHandler(this.rbtnInactivo_CheckedChanged);
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnActivo.Location = new System.Drawing.Point(186, 325);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(65, 19);
            this.rbtnActivo.TabIndex = 39;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(131, 296);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(173, 15);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado de la Competencia";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(131, 235);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(180, 15);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre de la Competencia";
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Location = new System.Drawing.Point(444, 150);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.RowHeadersWidth = 51;
            this.dgvCompetencias.Size = new System.Drawing.Size(508, 225);
            this.dgvCompetencias.TabIndex = 35;
            // 
            // lblIDCompetencia
            // 
            this.lblIDCompetencia.AutoSize = true;
            this.lblIDCompetencia.Enabled = false;
            this.lblIDCompetencia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCompetencia.Location = new System.Drawing.Point(131, 171);
            this.lblIDCompetencia.Name = "lblIDCompetencia";
            this.lblIDCompetencia.Size = new System.Drawing.Size(110, 15);
            this.lblIDCompetencia.TabIndex = 34;
            this.lblIDCompetencia.Text = "ID Competencia";
            // 
            // NavegadorCompetencias
            // 
            this.NavegadorCompetencias.BackColor = System.Drawing.Color.Transparent;
            this.NavegadorCompetencias.Location = new System.Drawing.Point(12, 12);
            this.NavegadorCompetencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NavegadorCompetencias.Name = "NavegadorCompetencias";
            this.NavegadorCompetencias.Size = new System.Drawing.Size(1059, 105);
            this.NavegadorCompetencias.TabIndex = 41;
            this.NavegadorCompetencias.Load += new System.EventHandler(this.NavegadorCompetencias_Load);
            // 
            // txtIDCompetencia
            // 
            this.txtIDCompetencia.Location = new System.Drawing.Point(134, 190);
            this.txtIDCompetencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDCompetencia.Name = "txtIDCompetencia";
            this.txtIDCompetencia.Size = new System.Drawing.Size(242, 20);
            this.txtIDCompetencia.TabIndex = 42;
            this.txtIDCompetencia.Tag = "pk_id_tipo_competencia";
            this.txtIDCompetencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 254);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 20);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.Tag = "nombre_competencia";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(402, 358);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(28, 20);
            this.txtEstado.TabIndex = 44;
            this.txtEstado.Tag = "estado_competencia";
            this.txtEstado.Visible = false;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // frmTipoCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1079, 413);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCompetencia);
            this.Controls.Add(this.NavegadorCompetencias);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvCompetencias);
            this.Controls.Add(this.lblIDCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTipoCompetencia";
            this.Text = "310 - Mantenimientos de Competencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Label lblIDCompetencia;
        private CapaVistaNavegador.Navegador NavegadorCompetencias;
        private System.Windows.Forms.TextBox txtIDCompetencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstado;
    }
}