using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Vista_Mantenimientos.Faltas
{
    public partial class frmFaltas : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmFaltas(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            NavegadorFaltas.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }
        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void rbtnActivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rbtnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (txtEstado.Text == "")
            {
                rbtnActivo.Checked = false;
                rbtnInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rbtnActivo.Checked = true;
            }
        }

        private void NavegadorFaltas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
