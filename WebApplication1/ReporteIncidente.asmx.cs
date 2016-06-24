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

    public class ReporteIncidente : System.Web.Services.WebService
    {
        [WebMethod]
        public int InsertIncidencia(int action, int id_incidencia, string img, string observacion)
        {
            int reportIn;
            ReportarIncidente report = new ReportarIncidente();

            reportIn = report.InsertIncidencia(action, id_incidencia, img, observacion);

            return reportIn;
        }
        [WebMethod]
        public List<ReportarIncidente> selectIncidentes(int action)
        {
            List<ReportarIncidente> reportIncidente = new List<ReportarIncidente>();
            DataTable ReportIncident = new DataTable();
            ReportarIncidente Report = new ReportarIncidente();

            ReportIncident = Report.selectIncidentes(action);

            foreach (DataRow row in ReportIncident.Rows)
            {
                reportIncidente.Add(new ReportarIncidente() { _id_incidencia = Int32.Parse(row["id"].ToString()), _nombre = row["nombre_incidencia"].ToString() });
            }

            return reportIncidente;
        }
    }
}
