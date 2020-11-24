using Capa_Controlador.Controlador_Desarrollo;
using Capa_Vista.Vista_Reclutamiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Vista_Desarrollo
{
    public partial class frmCompetencias : Form
    {
        clsControladorDesarrollo Cont = new clsControladorDesarrollo();

        List<int> IDs_Competencia = new List<int>();
        List<int> Resultados = new List<int>();

        public frmCompetencias()
        {
            InitializeComponent();
            funcLlenarCompetencia();
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        private bool funcValidarFechas(string FI, string FF)
        {
            return false;

        }

        public void funcLlenarCompetencia()
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCompetencias_Load(object sender, EventArgs e)
        {
            //Limite de Caracteres
            txtResultado.MaxLength = 3;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
           //Mostrar Listado de Empleados
            frmMostrarEmpleado MostrarEmp = new frmMostrarEmpleado();
            MostrarEmp.ShowDialog();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            

        }
    }
}
