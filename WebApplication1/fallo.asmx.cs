using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Connection;

namespace WebApplication1
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]

    public class fallo : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Fallo> selectItems(int action)
        {
            List<Fallo> fail = new List<Fallo>();
            DataTable failTable = new DataTable();
            Fallo failData = new Fallo();

            failTable = failData.select(action);
            if (action == 3)
            {
                foreach (DataRow row in failTable.Rows)
                {
                    fail.Add(new Fallo() { _id = Int32.Parse(row["id"].ToString()), _nombre = row["nombreC"].ToString() });
                }

            }
            else if (action == 4)
            {
                foreach (DataRow row in failTable.Rows)
                {
                    fail.Add(new Fallo() { _id = Int32.Parse(row["id"].ToString()), _nombre = row["nombreFC"].ToString() });
                }
            }

            return fail;
        }
        [WebMethod]
        public List<Fallo> selectItemsSave(int action,int id)
        {
            List<Fallo> fail = new List<Fallo>();
            DataTable failTable = new DataTable();
            Fallo failData = new Fallo();

            failTable = failData.selectItemSave(action,id);

            foreach (DataRow row in failTable.Rows)
            {
                fail.Add(new Fallo() { _id = Int32.Parse(row["id"].ToString()), _id_tabla = Int32.Parse(row["id_reporteD"].ToString()), _nombreFC = row["nombreFC"].ToString(), _nombre = row["nombreC"].ToString(),_severidad = row["severidad"].ToString() });
            }

            return fail;

        }

        [WebMethod]
        public int InsertarActividades(int action, int id_reporteD, int id_ccomponente, int id_falloC, string severidad)
        {
            int actividades;
            Fallo actividad = new Fallo();
            actividades = actividad.InsertarActividades(action, id_reporteD, id_ccomponente, id_falloC, severidad);

            return actividades;
        }

        [WebMethod]
        public int TerminarTurno(int action, int id ,string fecha_fin, string hora_fin)
        {
            int actividades;
            Fallo actividad = new Fallo();
            actividades = actividad.TerminarTurno(action, id, fecha_fin, hora_fin);

            return actividades;
        }
        [WebMethod]
        public int DeleteActividades(int action, int id)
        {
            int actividades;
            Fallo actividad = new Fallo();
            actividades = actividad.DeleteActividades(action, id);

            return actividades;
        }
    }
}
