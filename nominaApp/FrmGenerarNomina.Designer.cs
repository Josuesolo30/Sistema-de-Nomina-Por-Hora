namespace nominaApp
{
    partial class FrmGenerarNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarNomina = new System.Windows.Forms.Button();
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            this.EmpleadoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDescuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(156, 57);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(245, 22);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(156, 115);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(245, 22);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // btnGenerarNomina
            // 
            this.btnGenerarNomina.Location = new System.Drawing.Point(536, 71);
            this.btnGenerarNomina.Name = "btnGenerarNomina";
            this.btnGenerarNomina.Size = new System.Drawing.Size(148, 60);
            this.btnGenerarNomina.TabIndex = 4;
            this.btnGenerarNomina.Text = "Generar Nomina";
            this.btnGenerarNomina.UseVisualStyleBackColor = true;
            this.btnGenerarNomina.Click += new System.EventHandler(this.btnGenerarNomina_Click_1);
            // 
            // dgvNomina
            // 
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpleadoID,
            this.Nombre,
            this.SueldoBruto,
            this.TotalIngresos,
            this.TotalDescuentos,
            this.SueldoNeto});
            this.dgvNomina.Location = new System.Drawing.Point(57, 188);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.RowHeadersWidth = 51;
            this.dgvNomina.RowTemplate.Height = 24;
            this.dgvNomina.Size = new System.Drawing.Size(788, 198);
            this.dgvNomina.TabIndex = 5;
            // 
            // EmpleadoID
            // 
            this.EmpleadoID.HeaderText = "Empleado";
            this.EmpleadoID.MinimumWidth = 6;
            this.EmpleadoID.Name = "EmpleadoID";
            this.EmpleadoID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // SueldoBruto
            // 
            this.SueldoBruto.HeaderText = "Sueldo Bruto";
            this.SueldoBruto.MinimumWidth = 6;
            this.SueldoBruto.Name = "SueldoBruto";
            this.SueldoBruto.Width = 125;
            // 
            // TotalIngresos
            // 
            this.TotalIngresos.HeaderText = "Total Ingresos";
            this.TotalIngresos.MinimumWidth = 6;
            this.TotalIngresos.Name = "TotalIngresos";
            this.TotalIngresos.Width = 125;
            // 
            // TotalDescuentos
            // 
            this.TotalDescuentos.HeaderText = "Total Descuentos";
            this.TotalDescuentos.MinimumWidth = 6;
            this.TotalDescuentos.Name = "TotalDescuentos";
            this.TotalDescuentos.Width = 125;
            // 
            // SueldoNeto
            // 
            this.SueldoNeto.HeaderText = "SueldoNeto";
            this.SueldoNeto.MinimumWidth = 6;
            this.SueldoNeto.Name = "SueldoNeto";
            this.SueldoNeto.Width = 125;
            // 
            // FrmGenerarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.dgvNomina);
            this.Controls.Add(this.btnGenerarNomina);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label1);
            this.Name = "FrmGenerarNomina";
            this.Text = "FrmGenerarNomina";
            this.Load += new System.EventHandler(this.FrmGenerarNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnGenerarNomina;
        private System.Windows.Forms.DataGridView dgvNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoNeto;
    }
}