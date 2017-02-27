using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class Actividades
    {
        #region Atributos  

        private int id;
        private int id_actividad;
        private int id_no_trbaajadas;
        private string nombre_actividad;
        private string nombre_no_trbajada;
        private decimal horas_actividades;
        private decimal horas_no_trabajadas;

        #endregion

        #region Get y Set 
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _id_actividad
        {
            get { return id_actividad; }    
            set { id_actividad = value; }
        }
        public int _id_no_trbaajadas
        {
            get { return id_no_trbaajadas; }
            set { id_no_trbaajadas = value; }
        }
        public string _nombre_actividad
        {
            get { return nombre_actividad; }
            set { nombre_actividad = value; }
        }
        public string _nombre_no_trbajada
        {
            get { return nombre_no_trbajada; }
            set { nombre_no_trbajada = value; }
        }
        public decimal _horas_actividades
        {
            get { return horas_actividades; }
            set { horas_actividades = value; }
        }
        public decimal _horas_no_trabajadas
        {
            get { return horas_no_trabajadas; }
            set { horas_no_trabajadas = value; }
        }
        #endregion

        #region Metodos CRUD

        public DataTable selectActividades(int action, int frenteId)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm2");
            comando.Parameters.AddWithValue("@action",action);
            comando.Parameters.AddWithValue("@id_frente", frenteId);
            return ConexionBD.EjecutarSelect(comando);
        }
        public DataTable selectActividadesTyNT(int action, int id)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm2");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id", id);
            return ConexionBD.EjecutarSelect(comando);
        }
        public int InsertarActividades(int action,int id_ReporteD,int id_Actividades, decimal horas)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm2");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id_ReporteD", id_ReporteD);
            comando.Parameters.AddWithValue("@id_Actividades", id_Actividades);
            comando.Parameters.AddWithValue("@horas", horas);
            return ConexionBD.EjecutarComando(comando);
        }
        public int UpdatehorasProgramadas(int action, int id, decimal horas_programadas)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm2");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@horas_programadas", horas_programadas);
            comando.Parameters.AddWithValue("@id", id);
            return ConexionBD.EjecutarComando(comando);
        }

        public int DeleteActividades(int action, int id)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm2");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id", id);
            return ConexionBD.EjecutarComando(comando);
        }

        #endregion
    }
}
