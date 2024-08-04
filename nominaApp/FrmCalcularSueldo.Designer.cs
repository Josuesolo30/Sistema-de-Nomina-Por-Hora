namespace nominaApp
{
    partial class FrmCalcularSueldo
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.EmpleadoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoPorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldoPorHora = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpleadoID,
            this.Nombre,
            this.SueldoPorHora});
            this.dgvEmpleados.Location = new System.Drawing.Point(58, 208);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(662, 188);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // EmpleadoID
            // 
            this.EmpleadoID.HeaderText = "EmpleadoID";
            this.EmpleadoID.MinimumWidth = 6;
            this.EmpleadoID.Name = "EmpleadoID";
            this.EmpleadoID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // SueldoPorHora
            // 
            this.SueldoPorHora.HeaderText = "SueldoPorHora";
            this.SueldoPorHora.MinimumWidth = 6;
            this.SueldoPorHora.Name = "SueldoPorHora";
            this.SueldoPorHora.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sueldo";
            // 
            // txtSueldoPorHora
            // 
            this.txtSueldoPorHora.Location = new System.Drawing.Point(184, 92);
            this.txtSueldoPorHora.Name = "txtSueldoPorHora";
            this.txtSueldoPorHora.Size = new System.Drawing.Size(122, 22);
            this.txtSueldoPorHora.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(544, 92);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(161, 60);
            this.btn.TabIndex = 3;
            this.btn.Text = "Calcular Sueldo ";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // FrmCalcularSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtSueldoPorHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "FrmCalcularSueldo";
            this.Text = "FrmCalcularSueldo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoPorHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldoPorHora;
        private System.Windows.Forms.Button btn;
    }
}