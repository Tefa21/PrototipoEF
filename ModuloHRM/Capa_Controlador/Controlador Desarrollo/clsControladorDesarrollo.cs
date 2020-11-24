using Capa_Modelo.Modelo_Desarrollo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador.Controlador_Desarrollo
{
    public class clsControladorDesarrollo
    {
        clsConsultaDesarrollo sn = new clsConsultaDesarrollo();
        public DataTable funcItemsHorario()
        {
            //Paso de Paramaetros en el controlador para ComboBox
            DataTable Items = sn.funcCmbHorario();
            return Items;
        }

        public DataTable funcCmbCompetencia()
        {
            //Paso de Paramaetros en el controlador para ComboBox
            DataTable Items = sn.funcCmbCompetencia();
            return Items;
        }

        public void funcCrearPeriodo(string IDEmp, string FI, string FF, List<int> IDs_Competencias, List<int> Resultados)
        {
            //Paso de Paramaetros en el controlador para Ingresar Competencias
            sn.funcIngresoCompetencias(IDEmp, FI, FF, IDs_Competencias, Resultados);
        }

        //Paso de datos para consulta mostrar en la entidad empleado
        public DataTable funcTablaEmpleado(int Estado)
        {
            OdbcDataAdapter dt = sn.funcTablaEmpleado(Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Id
        public DataTable funcFiltradoIdEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoIdEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Primer Nombre
        public DataTable funcFiltradoNombreEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoNombreEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Primer Apellido
        public DataTable funcFiltradoApellidoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoApellidoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Puesto
        public DataTable funcFiltradoPuestoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoPuestoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Departamento
        public DataTable funcFiltradoDepartamentoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoDepartamentoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
