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
            btn_BuscarCliente = new Krypton.Toolkit.KryptonButton();
            btnSeleccionarCliente = new Krypton.Toolkit.KryptonButton();
            dtgClientes = new Krypton.Toolkit.KryptonDataGridView();
            txtBuscar = new TextBox();
            TxtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(TxtId);
            kryptonPanel1.Controls.Add(btn_BuscarCliente);
            kryptonPanel1.Controls.Add(btnSeleccionarCliente);
            kryptonPanel1.Controls.Add(dtgClientes);
            kryptonPanel1.Controls.Add(txtBuscar);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(4);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(554, 508);
            kryptonPanel1.TabIndex = 0;
            // 
            // btn_BuscarCliente
            // 
            btn_BuscarCliente.Location = new Point(315, 410);
            btn_BuscarCliente.Margin = new Padding(4);
            btn_BuscarCliente.Name = "btn_BuscarCliente";
            btn_BuscarCliente.Size = new Size(196, 64);
            btn_BuscarCliente.TabIndex = 9;
            btn_BuscarCliente.Values.DropDownArrowColor = Color.Empty;
            btn_BuscarCliente.Values.Text = "Buscar";
            btn_BuscarCliente.Click += btn_BuscarCliente_Click;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Location = new Point(54, 410);
            btnSeleccionarCliente.Margin = new Padding(4);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(196, 64);
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
            dtgClientes.Location = new Point(22, 91);
            dtgClientes.Margin = new Padding(4);
            dtgClientes.Name = "dtgClientes";
            dtgClientes.ReadOnly = true;
            dtgClientes.RowHeadersWidth = 51;
            dtgClientes.Size = new Size(498, 311);
            dtgClientes.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(4, 20);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(321, 39);
            txtBuscar.TabIndex = 6;
            txtBuscar.Text = "Buscar Cliente";
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(365, 24);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(155, 31);
            TxtId.TabIndex = 10;
            // 
            // UC_ClienteExiste
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Margin = new Padding(4);
            Name = "UC_ClienteExiste";
            Size = new Size(554, 508);
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
        private Krypton.Toolkit.KryptonButton btn_BuscarCliente;
        private TextBox TxtId;
    }
}
