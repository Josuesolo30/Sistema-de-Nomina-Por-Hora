using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nominaApp.Class
{
    public static class DatabaseConnection
    {
        private static string connectionString = @"Data Source=DESKTOP-VHARLSG; Initial Catalog=NominaDB; Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
