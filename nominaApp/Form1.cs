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
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroEmpleado frmRegistroEmpleado = new FrmRegistroEmpleado();
            frmRegistroEmpleado.ShowDialog();
        }

        private void calcularSueldoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCalcularSueldo frmCalcularSueldo = new FrmCalcularSueldo();
            frmCalcularSueldo.ShowDialog();
        }
        private void registrarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroMovimientos frmRegistroMovimientos = new FrmRegistroMovimientos();
            frmRegistroMovimientos.ShowDialog();
        }

        private void generarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarNomina frmGenerarNomina = new FrmGenerarNomina();
            frmGenerarNomina.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Inicialización del formulario si es necesario
        }

    }
}
