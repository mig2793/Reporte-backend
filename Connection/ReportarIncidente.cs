using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class ReportarIncidente
    {
        #region Atributos
        private int id;
        private string nombre;
        private int id_incidencia;
        private string img;
        private string observacion;
        #endregion

        #region Metodos Set Get
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
        public int _id_incidencia
        {
            get { return id_incidencia; }
            set { id_incidencia = value; }
        }
        public string _img
        {
            get { return img; }
            set { img = value; }
        }
        public string _observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        #endregion

        #region Metodos
        public int InsertIncidencia(int action,int id_incidencia, string img, string observacion)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportIncident");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id_CIncidencia", id_incidencia);
            comando.Parameters.AddWithValue("@img", img);
            comando.Parameters.AddWithValue("@observacion", observacion);
            return ConexionBD.EjecutarComando(comando);
        }
        public DataTable selectIncidentes(int action)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportIncident");
            comando.Parameters.AddWithValue("@action", action);
            return ConexionBD.EjecutarSelect(comando);
        }
        #endregion
    }
}
