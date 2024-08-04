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
    public partial class FrmRegistroMovimientos : Form
    {
        public FrmRegistroMovimientos()
        {
            InitializeComponent();
            LoadMovimientos();
            LoadComboBoxData();  // Método para cargar datos en los ComboBox
        }

        private void LoadMovimientos()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MovimientoID, Descripcion, TipoMovimiento, ProcedimientoCalculo FROM Movimientos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtMovimientos = new DataTable();
                adapter.Fill(dtMovimientos);
                dgvMovimientos.DataSource = dtMovimientos;
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    // Cargar TipoMovimiento
                    string queryTipoMovimiento = "SELECT DISTINCT TipoMovimiento FROM Movimientos";
                    SqlDataAdapter adapterTipoMovimiento = new SqlDataAdapter(queryTipoMovimiento, connection);
                    DataTable dtTipoMovimiento = new DataTable();
                    adapterTipoMovimiento.Fill(dtTipoMovimiento);

                    if (dtTipoMovimiento.Rows.Count > 0)
                    {
                        cbTipoMovimiento.DataSource = dtTipoMovimiento;
                        cbTipoMovimiento.DisplayMember = "TipoMovimiento";
                        cbTipoMovimiento.ValueMember = "TipoMovimiento";
                    }
                    else
                    {
                        cbTipoMovimiento.DataSource = null;
                    }

                    // Cargar ProcedimientoCalculo
                    string queryProcedimientoCalculo = "SELECT DISTINCT ProcedimientoCalculo FROM Movimientos";
                    SqlDataAdapter adapterProcedimientoCalculo = new SqlDataAdapter(queryProcedimientoCalculo, connection);
                    DataTable dtProcedimientoCalculo = new DataTable();
                    adapterProcedimientoCalculo.Fill(dtProcedimientoCalculo);

                    if (dtProcedimientoCalculo.Rows.Count > 0)
                    {
                        cbProcedimientoCalculo.DataSource = dtProcedimientoCalculo;
                        cbProcedimientoCalculo.DisplayMember = "ProcedimientoCalculo";
                        cbProcedimientoCalculo.ValueMember = "ProcedimientoCalculo";
                    }
                    else
                    {
                        cbProcedimientoCalculo.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBox: " + ex.Message);
            }
        }

        private void FrmRegistroMovimientos_Load(object sender, EventArgs e)
        {
            // No es necesario si ya se cargan los ComboBox en el constructor
        }

        private void btnRegistrarMovimiento_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Movimientos (Descripcion, TipoMovimiento, ProcedimientoCalculo) VALUES (@Descripcion, @TipoMovimiento, @ProcedimientoCalculo)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    command.Parameters.AddWithValue("@TipoMovimiento", cbTipoMovimiento.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@ProcedimientoCalculo", cbProcedimientoCalculo.SelectedValue.ToString());

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Movimiento registrado exitosamente");

                    LoadMovimientos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el movimiento: " + ex.Message);
            }
        }
    }
}
