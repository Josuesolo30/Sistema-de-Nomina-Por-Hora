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
    public partial class FrmGenerarNomina : Form
    {
        public FrmGenerarNomina()
        {
            InitializeComponent();
        }

        private void ConfigureDataGridView()
        {
            dgvNomina.Columns.Clear();

            dgvNomina.Columns.Add("EmpleadoID", "Empleado ID");
            dgvNomina.Columns["EmpleadoID"].DataPropertyName = "EmpleadoID";

            dgvNomina.Columns.Add("Nombre", "Nombre");
            dgvNomina.Columns["Nombre"].DataPropertyName = "Nombre";

            dgvNomina.Columns.Add("TotalHorasNormales", "Total Horas Normales");
            dgvNomina.Columns["TotalHorasNormales"].DataPropertyName = "TotalHorasNormales";

            dgvNomina.Columns.Add("TotalHorasExtras", "Total Horas Extras");
            dgvNomina.Columns["TotalHorasExtras"].DataPropertyName = "TotalHorasExtras";

            dgvNomina.Columns.Add("TotalIngresos", "Total Ingresos");
            dgvNomina.Columns["TotalIngresos"].DataPropertyName = "TotalIngresos";

            dgvNomina.Columns.Add("TotalDescuentos", "Total Descuentos");
            dgvNomina.Columns["TotalDescuentos"].DataPropertyName = "TotalDescuentos";

            dgvNomina.Columns.Add("SueldoBruto", "Sueldo Bruto");
            dgvNomina.Columns["SueldoBruto"].DataPropertyName = "SueldoBruto";

            dgvNomina.Columns.Add("SueldoNeto", "Sueldo Neto");
            dgvNomina.Columns["SueldoNeto"].DataPropertyName = "SueldoNeto";
        }

        private void FrmGenerarNomina_Load(object sender, EventArgs e)
        {
            // Inicialización del formulario si es necesario
        }

        private void btnGenerarNomina_Click_1(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
            SELECT e.EmpleadoID, e.Nombre,
                ISNULL(SUM(ht.HorasNormales * e.SueldoPorHora), 0) AS SueldoBrutoHorasNormales,
                ISNULL(SUM(ht.HorasExtras * e.SueldoPorHora * 1.5), 0) AS SueldoBrutoHorasExtras,
                ISNULL(SUM(CASE WHEN m.TipoMovimiento = 'Ingreso' THEN me.Monto ELSE 0 END), 0) AS TotalIngresos,
                ISNULL(SUM(CASE WHEN m.TipoMovimiento = 'Descuento' THEN me.Monto ELSE 0 END), 0) AS TotalDescuentos,
                (ISNULL(SUM(ht.HorasNormales * e.SueldoPorHora), 0) +
                 ISNULL(SUM(ht.HorasExtras * e.SueldoPorHora * 1.5), 0) +
                 ISNULL(SUM(CASE WHEN m.TipoMovimiento = 'Ingreso' THEN me.Monto ELSE 0 END), 0) -
                 ISNULL(SUM(CASE WHEN m.TipoMovimiento = 'Descuento' THEN me.Monto ELSE 0 END), 0)) AS SueldoNeto
        FROM Empleados e
        LEFT JOIN HorasTrabajadas ht ON e.EmpleadoID = ht.EmpleadoID AND ht.Fecha BETWEEN @FechaInicio AND @FechaFin
        LEFT JOIN MovimientosEmpleados me ON e.EmpleadoID = me.EmpleadoID AND me.FechaMovimiento BETWEEN @FechaInicio AND @FechaFin
        LEFT JOIN Movimientos m ON me.MovimientoID = m.MovimientoID
        GROUP BY e.EmpleadoID, e.Nombre, e.SueldoPorHora";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@FechaFin", fechaFin);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtNomina = new DataTable();
                adapter.Fill(dtNomina);

                dgvNomina.DataSource = dtNomina;
                ConfigureDataGridView();
            }
        }

    }
 }
