using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Data;
using Connection;

namespace WebApplication1
{
    [WebService(Namespace = "http://192.168.0.130:85/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]

    public class actividadesControl : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Actividades> selectActividades(int action)
        {
            List<Actividades> actividades = new List<Actividades>();
            DataTable actividadesT = new DataTable();
            Actividades actividad = new Actividades();

            actividadesT = actividad.selectActividades(action);

            foreach (DataRow row in actividadesT.Rows)
            {
                actividades.Add(new Actividades() { _id = Int32.Parse(row["id"].ToString()), _nombre_actividad = row["nombre"].ToString()});
            }

            return actividades;
        }
        [WebMethod]
        public List<Actividades> selectActividadesTyNT(int action, int id)
        {
            List<Actividades> actividades = new List<Actividades>();
            DataTable actividadesT = new DataTable();
            Actividades actividad = new Actividades();

            actividadesT = actividad.selectActividadesTyNT(action,id);

            if (action == 7)
            {
                foreach (DataRow row in actividadesT.Rows)
                {
                    actividades.Add(new Actividades() { _id = Int32.Parse(row["id"].ToString()), _id_actividad = Int32.Parse(row["id_Actividades"].ToString()), _horas_actividades = Int32.Parse(row["horas"].ToString()), _nombre_actividad = row["nombre"].ToString() });
                }

            }
            else if (action == 8)
            {
                foreach (DataRow row in actividadesT.Rows)
                {
                    actividades.Add(new Actividades() { _id = Int32.Parse(row["id"].ToString()), _id_actividad = Int32.Parse(row["id_ActividadesNT"].ToString()), _horas_actividades = Int32.Parse(row["horas"].ToString()), _nombre_actividad = row["nombre"].ToString() });
                }
            }


            return actividades;
        } 
        [WebMethod]
        public int InsertarActividades(int action, int id_ReporteD, int id_Actividades, int horas)
        {
            int actividadesT;
            Actividades actividad = new Actividades();
            actividadesT = actividad.InsertarActividades(action, id_ReporteD, id_Actividades, horas);

            return actividadesT;
        }
        [WebMethod]
        public int UpdatehorasProgramadas(int action, int id, int horas_programdas)
        {
            int actividadesT;
            Actividades actividad = new Actividades();
            actividadesT = actividad.UpdatehorasProgramadas(action, id, horas_programdas);

            return actividadesT;
        }
        [WebMethod]
        public int DeleteActividades(int action, int id)
        {
            int actividadesT;
            Actividades actividad = new Actividades();
            actividadesT = actividad.DeleteActividades(action, id);

            return actividadesT;
        }
    }
}
