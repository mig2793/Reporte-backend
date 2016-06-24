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

    public class Registro : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Operadores> Login(int action,string user, string password)
        {
            List<Operadores> login = new List<Operadores>();
            DataTable loginUser = new DataTable();
            Operadores operador = new Operadores();

            loginUser = operador.LoginUser(action,user, password);

            foreach (DataRow row in loginUser.Rows)
            {
                login.Add(new Operadores() { _name = row["nombre"].ToString(), _password = row["empleado"].ToString(), _lastname = row["apellido"].ToString(), _charge = row["cargo"].ToString(), _codCharge = row["oficio"].ToString(), _nit = row["empleado"].ToString()});
            }

            return login;
        }

    }
}
