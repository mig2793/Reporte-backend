using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class Operadores
    {
        #region Atributos
        private string nit;
        private string name;
        private string lastname;
        private string charge;
        private string codCharge;
        private string state;
        private string user;
        private string password;
        #endregion

        #region Metodos Set Get
        public string _nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public string _lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string _charge
        {
            get { return charge; }
            set { charge = value; }
        }
        public string _codCharge
        {
            get { return codCharge; }
            set { codCharge = value; }
        }
        public string _state
        {
            get { return state; }
            set { state = value; }
        }
        public string _user
        {
            get { return user; }
            set { user = value; }
        }
        public string _password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #region Metodos
        public DataTable LoginUser(int action,string user, string password)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("OperatorSP"); 
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@password", password);

            return ConexionBD.EjecutarSelect(comando);
        }
        #endregion
    }
}
