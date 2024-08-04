namespace nominaApp
{
    partial class FrmRegistroMovimientos
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProcedimientoCalculo = new System.Windows.Forms.ComboBox();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.MovimientoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedimientoCalculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(146, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Movimiento";
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Location = new System.Drawing.Point(195, 124);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(121, 24);
            this.cbTipoMovimiento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Procedimiento de Calculo";
            // 
            // cbProcedimientoCalculo
            // 
            this.cbProcedimientoCalculo.FormattingEnabled = true;
            this.cbProcedimientoCalculo.Location = new System.Drawing.Point(535, 69);
            this.cbProcedimientoCalculo.Name = "cbProcedimientoCalculo";
            this.cbProcedimientoCalculo.Size = new System.Drawing.Size(121, 24);
            this.cbProcedimientoCalculo.TabIndex = 5;
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(534, 124);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(122, 73);
            this.btnRegistrarMovimiento.TabIndex = 6;
            this.btnRegistrarMovimiento.Text = "Registar Movimiento";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click_1);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovimientoID,
            this.Descripcion,
            this.TipoMovimiento,
            this.ProcedimientoCalculo});
            this.dgvMovimientos.Location = new System.Drawing.Point(73, 240);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersWidth = 51;
            this.dgvMovimientos.RowTemplate.Height = 24;
            this.dgvMovimientos.Size = new System.Drawing.Size(553, 164);
            this.dgvMovimientos.TabIndex = 7;
            // 
            // MovimientoID
            // 
            this.MovimientoID.HeaderText = "ID Movimiento";
            this.MovimientoID.MinimumWidth = 6;
            this.MovimientoID.Name = "MovimientoID";
            this.MovimientoID.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.HeaderText = "Tipo de Movmiento";
            this.TipoMovimiento.MinimumWidth = 6;
            this.TipoMovimiento.Name = "TipoMovimiento";
            this.TipoMovimiento.Width = 125;
            // 
            // ProcedimientoCalculo
            // 
            this.ProcedimientoCalculo.HeaderText = "Procedimiento de Calculo";
            this.ProcedimientoCalculo.MinimumWidth = 6;
            this.ProcedimientoCalculo.Name = "ProcedimientoCalculo";
            this.ProcedimientoCalculo.Width = 125;
            // 
            // FrmRegistroMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.btnRegistrarMovimiento);
            this.Controls.Add(this.cbProcedimientoCalculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoMovimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroMovimientos";
            this.Text = "Registro de Movimientos";
            this.Load += new System.EventHandler(this.FrmRegistroMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoMovimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProcedimientoCalculo;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovimientoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedimientoCalculo;
    }
}