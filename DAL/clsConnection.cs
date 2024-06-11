using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class clsConnection
    {
        public static string GetConnection()
        {
            return "server=107-04\\SQLEXPRESS;" +
                "database=PersonasDepartamentos;" +
                "Uid=SA;" +
                "pwd=mitesoro;" +
                "trustServerCertificate=true";
        }
    }
}
