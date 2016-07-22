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

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]

    public class dataBasics : System.Web.Services.WebService
    {

        [WebMethod]
        public List<datosBasicos> selectMaquina(int action, string codMaq)
        {
            List<datosBasicos> selectMaquina = new List<datosBasicos>();
            DataTable selectMaquinaDT = new DataTable();
            datosBasicos selectMaq = new datosBasicos();

            selectMaquinaDT = selectMaq.selectMaquina(action, codMaq);

            foreach (DataRow row in selectMaquinaDT.Rows)
            {
                selectMaquina.Add(new datosBasicos() { _codMaq = row["valor"].ToString() });
            }

            return selectMaquina;

        }
        [WebMethod]
        public List<datosBasicos> selectTrailer(int action)
        {
            List<datosBasicos> selectMaquina = new List<datosBasicos>();
            DataTable selectMaquinaDT = new DataTable();
            datosBasicos selectMaq = new datosBasicos();

            selectMaquinaDT = selectMaq.selectTrailer(action);

            foreach (DataRow row in selectMaquinaDT.Rows)
            {
                selectMaquina.Add(new datosBasicos() { _codTrailer = row["CodigoMaq"].ToString() });
            }

            return selectMaquina;

        }
        
       [WebMethod]
        public List<datosBasicos> selectReport(int action, string id_codMaq, string id_operario, string fecha_inicio)
        {
            List<datosBasicos> selectReporte = new List<datosBasicos>();
            DataTable selectReporteD = new DataTable();
            datosBasicos selectReport = new datosBasicos();

            selectReporteD = selectReport.selectAllReport(action, id_codMaq, id_operario, fecha_inicio);

            foreach (DataRow row in selectReporteD.Rows)
            {
                selectReporte.Add(new datosBasicos() { _id = Int32.Parse(row["id"].ToString()), _codMaq = row["id_codMaq"].ToString(), _codTrailer = row["id_codTrailer"].ToString(), _id_operario = row["id_operario"].ToString(), _fecha_inicio = row["fecha_inicio"].ToString(), _fecha_fin = row["fecha_fin"].ToString(), _horometro_inicial = Int32.Parse(row["horometro_inicial"].ToString()), _horometro_final = Int32.Parse(row["horometro_final"].ToString()), _kilometro_inicial = Int32.Parse(row["kilometro_inicial"].ToString()), _kilometro_final = Int32.Parse(row["kilometro_final"].ToString()),_num_celular = row["num_celular"].ToString(), _kilometro_i_trailer = Int32.Parse(row["kilometro_i_trailer"].ToString()), _kilometro_f_trailer = Int32.Parse(row["kilometro_f_trailer"].ToString()), _id_centroCostos = Int32.Parse(row["id_centroCostos"].ToString()), _id_frente = Int32.Parse(row["id_frente"].ToString()),  _horas_programadas = Int32.Parse(row["horas_programadas"].ToString()), _id_supervisor = Int32.Parse(row["id_supervisor"].ToString())});
            }

            return selectReporte;
        }
        [WebMethod]
        public int InsertDataBasic(int action, string id_codMaq, string id_operario, string fecha_inicio, string hora_inicio, int horometro_inicial, int horometro_final, int kilometro_inicial, int kilometro_final, string id_codTrailer, int kilometro_i_trailer, int kilometro_f_trailer, int id_centroCostos, int id_frente, string id_supervisor, string num_celular)
        {
            int dataBasic;
            datosBasicos dataBasics = new datosBasicos();
            dataBasic = dataBasics.InsertDataBasic(action, id_codMaq, id_operario, fecha_inicio, hora_inicio, horometro_inicial, horometro_final, kilometro_inicial, kilometro_final, id_codTrailer, kilometro_i_trailer, kilometro_f_trailer, id_centroCostos, id_frente, id_supervisor, num_celular);

            return dataBasic;
        }
        [WebMethod]
        public int UpdateDataBasic(int action, string id, int horometro_inicial, int horometro_final, int kilometro_inicial, int kilometro_final, string id_codTrailer, int kilometro_i_trailer, int kilometro_f_trailer, string num_celular)
        {
            int dataBasic;
            datosBasicos dataBasics = new datosBasicos();
            dataBasic = dataBasics.UpdateDataBasic(action, id, horometro_inicial, horometro_final, kilometro_inicial, kilometro_final, id_codTrailer, kilometro_i_trailer, kilometro_f_trailer, num_celular);

            return dataBasic;
        }
    }
}
