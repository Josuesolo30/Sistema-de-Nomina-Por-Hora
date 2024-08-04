using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace nominaApp.Class
{
    public class Conexion
    {
        private SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=DESKTOP-VHARLSG; Initial Catalog=NominaDB; Trusted_Connection=True;");
                cnx.Open();
                MessageBox.Show("Conectado correctamente", "Exito al conectar", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}