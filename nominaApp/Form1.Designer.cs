namespace nominaApp
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularSueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEmpleadoToolStripMenuItem,
            this.calcularSueldoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registrarEmpleadoToolStripMenuItem
            // 
            this.registrarEmpleadoToolStripMenuItem.Name = "registrarEmpleadoToolStripMenuItem";
            this.registrarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.registrarEmpleadoToolStripMenuItem.Text = "Registrar Empleado";
            this.registrarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMovimientoToolStripMenuItem,
            this.generarNominaToolStripMenuItem});
            this.movimientosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // registrarMovimientoToolStripMenuItem
            // 
            this.registrarMovimientoToolStripMenuItem.Name = "registrarMovimientoToolStripMenuItem";
            this.registrarMovimientoToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.registrarMovimientoToolStripMenuItem.Text = "Registrar Movimiento";
            this.registrarMovimientoToolStripMenuItem.Click += new System.EventHandler(this.registrarMovimientoToolStripMenuItem_Click);
            // 
            // generarNominaToolStripMenuItem
            // 
            this.generarNominaToolStripMenuItem.Name = "generarNominaToolStripMenuItem";
            this.generarNominaToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.generarNominaToolStripMenuItem.Text = "Generar Nómina";
            this.generarNominaToolStripMenuItem.Click += new System.EventHandler(this.generarNominaToolStripMenuItem_Click);
            // 
            // calcularSueldoToolStripMenuItem
            // 
            this.calcularSueldoToolStripMenuItem.Name = "calcularSueldoToolStripMenuItem";
            this.calcularSueldoToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.calcularSueldoToolStripMenuItem.Text = "Calcular Sueldo";
            this.calcularSueldoToolStripMenuItem.Click += new System.EventHandler(this.calcularSueldoToolStripMenuItem_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularSueldoToolStripMenuItem;
    }
}
