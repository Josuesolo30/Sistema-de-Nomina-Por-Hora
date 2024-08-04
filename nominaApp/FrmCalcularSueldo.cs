using nominaApp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nominaApp
{
    public partial class FrmCalcularSueldo : Form
    {
        public FrmCalcularSueldo()
        {
            InitializeComponent();
            LoadEmpleados();
        }

        private void LoadEmpleados()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT EmpleadoID, Nombre FROM Empleados";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtEmpleados = new DataTable();
                adapter.Fill(dtEmpleados);
                dgvEmpleados.DataSource = dtEmpleados;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int empleadoID = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["EmpleadoID"].Value);

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT SueldoPorHora FROM Empleados WHERE EmpleadoID = @EmpleadoID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                    connection.Open();
                    object sueldo = command.ExecuteScalar();
                    connection.Close();

                    if (sueldo != null)
                    {
                        txtSueldoPorHora.Text = $"Sueldo por hora: {sueldo.ToString()}";
                    }
                    else
                    {
                        txtSueldoPorHora.Text = "No se encontró el sueldo por hora.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado.");
            }
        }
    }
}
