using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Connection
{
    class configuracion
    {
        static string cadenaconexion = @"Data Source=SQL01\SQLAPPS;Initial Catalog=OpMaquinaria;USER ID=sa; PASSWORD=mincivil123";

        public static string cadenacon
        {
            get
            {
                return cadenaconexion;
            }
        }
    }
}
