using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient;
using nominaApp.Class;

namespace nominaApp
{
    public partial class FrmRegistroEmpleado : Form
    {
        public FrmRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void FrmRegistroEmpleado_Load(object sender, EventArgs e)
        {
            // Código de inicialización si es necesario
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {

            // Validar que todos los campos estén completos y correctos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSector.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCelular.Text) ||
                string.IsNullOrWhiteSpace(txtProvincia.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !decimal.TryParse(txtSueldoPorHora.Text, out decimal sueldoPorHora))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            // Ejecutar la conexión a la base de datos
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Empleados (Nombre, Sector, Direccion, Celular, Provincia, Email, SueldoPorHora) VALUES (@Nombre, @Sector, @Direccion, @Celular, @Provincia, @Email, @SueldoPorHora)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Sector", txtSector.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Celular", txtCelular.Text);
                    command.Parameters.AddWithValue("@Provincia", txtProvincia.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@SueldoPorHora", sueldoPorHora);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Empleado registrado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el empleado: " + ex.Message);
            }
        }
     }
    }
    

