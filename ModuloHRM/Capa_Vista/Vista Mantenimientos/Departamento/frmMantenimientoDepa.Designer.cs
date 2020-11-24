namespace Capa_Vista.Vista_Mantenimientos.Departamento
{
    partial class frmMantenimientoDepa
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDepa = new System.Windows.Forms.Label();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.NavegadorDepartamentos = new CapaVistaNavegador.Navegador();
            this.txtIDepartamento = new System.Windows.Forms.TextBox();
            this.txtNombreDepa = new System.Windows.Forms.TextBox();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(133, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(176, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Departamento";
            // 
            // lblIDepa
            // 
            this.lblIDepa.AutoSize = true;
            this.lblIDepa.Enabled = false;
            this.lblIDepa.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDepa.Location = new System.Drawing.Point(133, 159);
            this.lblIDepa.Name = "lblIDepa";
            this.lblIDepa.Size = new System.Drawing.Size(117, 15);
            this.lblIDepa.TabIndex = 3;
            this.lblIDepa.Text = "ID Departamento";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(457, 145);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.RowHeadersWidth = 51;
            this.dgvDepartamentos.Size = new System.Drawing.Size(459, 225);
            this.dgvDepartamentos.TabIndex = 9;
            // 
            // NavegadorDepartamentos
            // 
            this.NavegadorDepartamentos.BackColor = System.Drawing.Color.Transparent;
            this.NavegadorDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.NavegadorDepartamentos.Name = "NavegadorDepartamentos";
            this.NavegadorDepartamentos.Size = new System.Drawing.Size(1059, 105);
            this.NavegadorDepartamentos.TabIndex = 10;
            this.NavegadorDepartamentos.Load += new System.EventHandler(this.NavegadorDepartamentos_Load);
            // 
            // txtIDepartamento
            // 
            this.txtIDepartamento.Location = new System.Drawing.Point(136, 178);
            this.txtIDepartamento.Name = "txtIDepartamento";
            this.txtIDepartamento.Size = new System.Drawing.Size(251, 20);
            this.txtIDepartamento.TabIndex = 11;
            this.txtIDepartamento.Tag = "pk_id__departamento_empresarial";
            this.txtIDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtNombreDepa
            // 
            this.txtNombreDepa.Location = new System.Drawing.Point(136, 242);
            this.txtNombreDepa.Name = "txtNombreDepa";
            this.txtNombreDepa.Size = new System.Drawing.Size(251, 20);
            this.txtNombreDepa.TabIndex = 12;
            this.txtNombreDepa.Tag = "nombre_departamento_empresarial";
            this.txtNombreDepa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnInactivo.Location = new System.Drawing.Point(270, 313);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(77, 19);
            this.rbtnInactivo.TabIndex = 31;
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
            this.rbtnActivo.Location = new System.Drawing.Point(188, 313);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(65, 19);
            this.rbtnActivo.TabIndex = 30;
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
            this.lblEstado.Location = new System.Drawing.Point(133, 284);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(169, 15);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "Estado del Departamento";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(425, 350);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(26, 20);
            this.txtEstado.TabIndex = 32;
            this.txtEstado.Tag = "estado_departamento_empresarial";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // frmMantenimientoDepa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1079, 413);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNombreDepa);
            this.Controls.Add(this.txtIDepartamento);
            this.Controls.Add(this.NavegadorDepartamentos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.lblIDepa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoDepa";
            this.Text = "307 - Mantenimiento Departamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDepa;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private CapaVistaNavegador.Navegador NavegadorDepartamentos;
        private System.Windows.Forms.TextBox txtIDepartamento;
        private System.Windows.Forms.TextBox txtNombreDepa;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
    }
}