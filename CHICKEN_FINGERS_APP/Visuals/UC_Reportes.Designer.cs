namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class UC_Reportes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnExcel = new Krypton.Toolkit.KryptonButton();
            btnHacerReporte = new Krypton.Toolkit.KryptonButton();
            dtpFin = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            txtFin = new TextBox();
            txtInicio = new TextBox();
            txtReporte = new TextBox();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnExcel);
            kryptonPanel1.Controls.Add(btnHacerReporte);
            kryptonPanel1.Controls.Add(dtpFin);
            kryptonPanel1.Controls.Add(dtpInicio);
            kryptonPanel1.Controls.Add(txtFin);
            kryptonPanel1.Controls.Add(txtInicio);
            kryptonPanel1.Controls.Add(txtReporte);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1000, 127);
            kryptonPanel1.TabIndex = 0;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(626, 52);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(169, 63);
            btnExcel.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcel.TabIndex = 9;
            btnExcel.Values.DropDownArrowColor = Color.Empty;
            btnExcel.Values.Text = "Descargar excel";
            // 
            // btnHacerReporte
            // 
            btnHacerReporte.Location = new Point(412, 52);
            btnHacerReporte.Name = "btnHacerReporte";
            btnHacerReporte.Size = new Size(169, 63);
            btnHacerReporte.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHacerReporte.TabIndex = 8;
            btnHacerReporte.Values.DropDownArrowColor = Color.Empty;
            btnHacerReporte.Values.Text = "Hacer reporte";
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(147, 86);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(221, 29);
            dtpFin.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFin.StateNormal.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFin.TabIndex = 7;
            dtpFin.ValueNullable = new DateTime(2025, 11, 20, 15, 19, 5, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(147, 46);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(221, 29);
            dtpInicio.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInicio.StateNormal.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInicio.TabIndex = 6;
            // 
            // txtFin
            // 
            txtFin.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFin.Location = new Point(23, 81);
            txtFin.Name = "txtFin";
            txtFin.ReadOnly = true;
            txtFin.Size = new Size(118, 34);
            txtFin.TabIndex = 5;
            txtFin.Text = "Fin";
            txtFin.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInicio
            // 
            txtInicio.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInicio.Location = new Point(23, 41);
            txtInicio.Name = "txtInicio";
            txtInicio.ReadOnly = true;
            txtInicio.Size = new Size(118, 34);
            txtInicio.TabIndex = 4;
            txtInicio.Text = "Inicio";
            txtInicio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtReporte
            // 
            txtReporte.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReporte.Location = new Point(302, 3);
            txtReporte.Name = "txtReporte";
            txtReporte.ReadOnly = true;
            txtReporte.Size = new Size(296, 34);
            txtReporte.TabIndex = 3;
            txtReporte.Text = "Reportes";
            txtReporte.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonPanel3);
            kryptonPanel2.Controls.Add(kryptonDataGridView1);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(0, 127);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1000, 696);
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Dock = DockStyle.Right;
            kryptonPanel3.Location = new Point(988, 0);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(12, 696);
            kryptonPanel3.TabIndex = 2;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.AllowUserToAddRows = false;
            kryptonDataGridView1.AllowUserToDeleteRows = false;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Location = new Point(70, 23);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.ReadOnly = true;
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.Size = new Size(848, 209);
            kryptonDataGridView1.TabIndex = 0;
            // 
            // fpEstadistico
            // 
            // 
            // UC_Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "UC_Reportes";
            Size = new Size(1000, 823);
            Load += UC_Reportes_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private TextBox txtReporte;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFin;
        private Krypton.Toolkit.KryptonDateTimePicker dtpInicio;
        private TextBox txtFin;
        private TextBox txtInicio;
        private Krypton.Toolkit.KryptonButton btnHacerReporte;
        private Krypton.Toolkit.KryptonButton btnExcel;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
    }
}
