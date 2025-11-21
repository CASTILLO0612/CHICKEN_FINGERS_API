namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class UC_ClienteExiste
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
            btnSeleccionarCliente = new Krypton.Toolkit.KryptonButton();
            dtgClientes = new Krypton.Toolkit.KryptonDataGridView();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnSeleccionarCliente);
            kryptonPanel1.Controls.Add(dtgClientes);
            kryptonPanel1.Controls.Add(txtBuscar);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(443, 406);
            kryptonPanel1.TabIndex = 0;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Location = new Point(148, 338);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(157, 51);
            btnSeleccionarCliente.TabIndex = 8;
            btnSeleccionarCliente.Values.DropDownArrowColor = Color.Empty;
            btnSeleccionarCliente.Values.Text = "Seleccionar cliente";
            btnSeleccionarCliente.Click += btnSeleccionarCliente_Click;
            // 
            // dtgClientes
            // 
            dtgClientes.AllowUserToAddRows = false;
            dtgClientes.AllowUserToDeleteRows = false;
            dtgClientes.BorderStyle = BorderStyle.None;
            dtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientes.Location = new Point(18, 73);
            dtgClientes.Name = "dtgClientes";
            dtgClientes.ReadOnly = true;
            dtgClientes.RowHeadersWidth = 51;
            dtgClientes.Size = new Size(398, 249);
            dtgClientes.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(68, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.ReadOnly = true;
            txtBuscar.Size = new Size(296, 34);
            txtBuscar.TabIndex = 6;
            txtBuscar.Text = "Buscar cliente";
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // UC_ClienteExiste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "UC_ClienteExiste";
            Size = new Size(443, 406);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView dtgClientes;
        private TextBox txtBuscar;
        private Krypton.Toolkit.KryptonButton btnSeleccionarCliente;
    }
}
