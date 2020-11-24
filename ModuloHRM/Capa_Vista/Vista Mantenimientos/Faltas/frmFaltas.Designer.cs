namespace Capa_Vista.Vista_Mantenimientos.Faltas
{
    partial class frmFaltas
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
            this.NavegadorFaltas = new CapaVistaNavegador.Navegador();
            this.dgvFaltas = new System.Windows.Forms.DataGridView();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDFaltas = new System.Windows.Forms.Label();
            this.txtIDFalta = new System.Windows.Forms.TextBox();
            this.txtNombreFalta = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // NavegadorFaltas
            // 
            this.NavegadorFaltas.BackColor = System.Drawing.Color.Transparent;
            this.NavegadorFaltas.Location = new System.Drawing.Point(12, 12);
            this.NavegadorFaltas.Name = "NavegadorFaltas";
            this.NavegadorFaltas.Size = new System.Drawing.Size(1059, 105);
            this.NavegadorFaltas.TabIndex = 0;
            this.NavegadorFaltas.Load += new System.EventHandler(this.NavegadorFaltas_Load);
            // 
            // dgvFaltas
            // 
            this.dgvFaltas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaltas.Location = new System.Drawing.Point(403, 139);
            this.dgvFaltas.Name = "dgvFaltas";
            this.dgvFaltas.RowHeadersWidth = 51;
            this.dgvFaltas.Size = new System.Drawing.Size(649, 262);
            this.dgvFaltas.TabIndex = 36;
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnInactivo.Location = new System.Drawing.Point(196, 370);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(77, 19);
            this.rbtnInactivo.TabIndex = 45;
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
            this.rbtnActivo.Location = new System.Drawing.Point(114, 370);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(65, 19);
            this.rbtnActivo.TabIndex = 44;
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
            this.lblEstado.Location = new System.Drawing.Point(59, 341);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(122, 15);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "Estado de la Falta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(59, 211);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 15);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre de la Falta";
            // 
            // lblIDFaltas
            // 
            this.lblIDFaltas.AutoSize = true;
            this.lblIDFaltas.Enabled = false;
            this.lblIDFaltas.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFaltas.Location = new System.Drawing.Point(59, 147);
            this.lblIDFaltas.Name = "lblIDFaltas";
            this.lblIDFaltas.Size = new System.Drawing.Size(59, 15);
            this.lblIDFaltas.TabIndex = 42;
            this.lblIDFaltas.Text = "ID Falta";
            // 
            // txtIDFalta
            // 
            this.txtIDFalta.Location = new System.Drawing.Point(62, 166);
            this.txtIDFalta.Name = "txtIDFalta";
            this.txtIDFalta.Size = new System.Drawing.Size(249, 20);
            this.txtIDFalta.TabIndex = 46;
            this.txtIDFalta.Tag = "pk_id_falta";
            this.txtIDFalta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtNombreFalta
            // 
            this.txtNombreFalta.Location = new System.Drawing.Point(62, 230);
            this.txtNombreFalta.Name = "txtNombreFalta";
            this.txtNombreFalta.Size = new System.Drawing.Size(249, 20);
            this.txtNombreFalta.TabIndex = 47;
            this.txtNombreFalta.Tag = "nombre_falta";
            this.txtNombreFalta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescripcion.Location = new System.Drawing.Point(59, 271);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(155, 15);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Descripción de la Falta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(62, 290);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(321, 37);
            this.txtDescripcion.TabIndex = 50;
            this.txtDescripcion.Tag = "descripcion_falta";
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(357, 369);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(26, 20);
            this.txtEstado.TabIndex = 51;
            this.txtEstado.Tag = "estado_falta";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // frmFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1079, 413);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombreFalta);
            this.Controls.Add(this.txtIDFalta);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIDFaltas);
            this.Controls.Add(this.dgvFaltas);
            this.Controls.Add(this.NavegadorFaltas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFaltas";
            this.Text = "308 - Mantenimientos de Faltas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador NavegadorFaltas;
        private System.Windows.Forms.DataGridView dgvFaltas;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDFaltas;
        private System.Windows.Forms.TextBox txtIDFalta;
        private System.Windows.Forms.TextBox txtNombreFalta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEstado;
    }
}