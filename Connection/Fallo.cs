using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class Fallo
    {
        #region Atributos  

        private int id;
        private string nombre;
        private string nombreFC;
        private int id_tabla;
        private int id_fallo;
        private int id_componenete;
        private string severidad;

        #endregion

        #region Get y Set 
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string _nombreFC
        {
            get { return nombreFC; }
            set { nombreFC = value; }
        }
        public int _id_tabla
        {
            get { return id_tabla; }
            set { id_tabla = value; }
        }
        public int _id_fallo
        {
            get { return id_fallo; }
            set { id_fallo = value; }
        }
        public int _id_componenete
        {
            get { return id_componenete; }
            set { id_componenete = value; }
        }
        public string _severidad
        {
            get { return severidad; }
            set { severidad = value; }
        }
        #endregion

        #region Metodos CRUD

        public DataTable select(int action)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm3");
            comando.Parameters.AddWithValue("@action", action);
            return ConexionBD.EjecutarSelect(comando);
        }
        public DataTable selectItemSave(int action, int id)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm3");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id_ReporteD", id);
            return ConexionBD.EjecutarSelect(comando);
        }
        public int InsertarActividades(int action, int id_reporteD, int id_ccomponente, int id_falloC, string severidad)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm3");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id_ReporteD", id_reporteD);
            comando.Parameters.AddWithValue("@id_componente", id_ccomponente);
            comando.Parameters.AddWithValue("@id_FalloC", id_falloC);
            comando.Parameters.AddWithValue("@severidad", severidad);
            return ConexionBD.EjecutarComando(comando);
        }

        public int DeleteActividades(int action, int id)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm3");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id", id);
            return ConexionBD.EjecutarComando(comando);
        }

        #endregion
    }
}
