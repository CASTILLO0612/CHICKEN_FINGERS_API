namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class UC_Clientes
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
            pnIzquierdo = new Krypton.Toolkit.KryptonPanel();
            txtClientes = new TextBox();
            dtgClientes = new Krypton.Toolkit.KryptonDataGridView();
            pnDerecho = new Krypton.Toolkit.KryptonPanel();
            btnAgregarCliente = new Krypton.Toolkit.KryptonButton();
            btnEditarCliente = new Krypton.Toolkit.KryptonButton();
            btnEliminarCliente = new Krypton.Toolkit.KryptonButton();
            txtId = new Krypton.Toolkit.KryptonTextBox();
            txtCedula = new Krypton.Toolkit.KryptonTextBox();
            txtDireccion = new Krypton.Toolkit.KryptonTextBox();
            txtEstado = new Krypton.Toolkit.KryptonTextBox();
            txtTelefono = new Krypton.Toolkit.KryptonTextBox();
            txtSegundoApellido = new Krypton.Toolkit.KryptonTextBox();
            txtPrimerApellido = new Krypton.Toolkit.KryptonTextBox();
            txtSegundoNombre = new Krypton.Toolkit.KryptonTextBox();
            txtPrimerNombre = new Krypton.Toolkit.KryptonTextBox();
            txtEditarClientes = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pnIzquierdo).BeginInit();
            pnIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnDerecho).BeginInit();
            pnDerecho.SuspendLayout();
            SuspendLayout();
            // 
            // pnIzquierdo
            // 
            pnIzquierdo.Controls.Add(txtClientes);
            pnIzquierdo.Controls.Add(dtgClientes);
            pnIzquierdo.Dock = DockStyle.Fill;
            pnIzquierdo.Location = new Point(0, 0);
            pnIzquierdo.Margin = new Padding(4);
            pnIzquierdo.Name = "pnIzquierdo";
            pnIzquierdo.Size = new Size(1250, 1029);
            pnIzquierdo.TabIndex = 0;
            // 
            // txtClientes
            // 
            txtClientes.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClientes.Location = new Point(111, 11);
            txtClientes.Margin = new Padding(4);
            txtClientes.Name = "txtClientes";
            txtClientes.ReadOnly = true;
            txtClientes.Size = new Size(369, 39);
            txtClientes.TabIndex = 4;
            txtClientes.Text = "Clientes registrados";
            txtClientes.TextAlign = HorizontalAlignment.Center;
            // 
            // dtgClientes
            // 
            dtgClientes.BorderStyle = BorderStyle.None;
            dtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientes.Location = new Point(4, 61);
            dtgClientes.Margin = new Padding(4);
            dtgClientes.Name = "dtgClientes";
            dtgClientes.RowHeadersWidth = 51;
            dtgClientes.Size = new Size(646, 882);
            dtgClientes.TabIndex = 0;
            dtgClientes.CellClick += dtgClientes_CellClick;
            // 
            // pnDerecho
            // 
            pnDerecho.Controls.Add(btnAgregarCliente);
            pnDerecho.Controls.Add(btnEditarCliente);
            pnDerecho.Controls.Add(btnEliminarCliente);
            pnDerecho.Controls.Add(txtId);
            pnDerecho.Controls.Add(txtCedula);
            pnDerecho.Controls.Add(txtDireccion);
            pnDerecho.Controls.Add(txtEstado);
            pnDerecho.Controls.Add(txtTelefono);
            pnDerecho.Controls.Add(txtSegundoApellido);
            pnDerecho.Controls.Add(txtPrimerApellido);
            pnDerecho.Controls.Add(txtSegundoNombre);
            pnDerecho.Controls.Add(txtPrimerNombre);
            pnDerecho.Controls.Add(txtEditarClientes);
            pnDerecho.Dock = DockStyle.Right;
            pnDerecho.Location = new Point(658, 0);
            pnDerecho.Margin = new Padding(4);
            pnDerecho.Name = "pnDerecho";
            pnDerecho.Size = new Size(592, 1029);
            pnDerecho.TabIndex = 1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(200, 706);
            btnAgregarCliente.Margin = new Padding(4);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(211, 79);
            btnAgregarCliente.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCliente.TabIndex = 17;
            btnAgregarCliente.Values.DropDownArrowColor = Color.Empty;
            btnAgregarCliente.Values.Text = "Agregar Cliente";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(328, 586);
            btnEditarCliente.Margin = new Padding(4);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(211, 79);
            btnEditarCliente.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarCliente.TabIndex = 16;
            btnEditarCliente.Values.DropDownArrowColor = Color.Empty;
            btnEditarCliente.Values.Text = "Editar cliente";
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(69, 586);
            btnEliminarCliente.Margin = new Padding(4);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(211, 79);
            btnEliminarCliente.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarCliente.TabIndex = 15;
            btnEliminarCliente.Values.DropDownArrowColor = Color.Empty;
            btnEliminarCliente.Values.Text = "Eliminar cliente";
            // 
            // txtId
            // 
            txtId.Location = new Point(242, 134);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(78, 35);
            txtId.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.TabIndex = 14;
            txtId.Text = "Id";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(69, 475);
            txtCedula.Margin = new Padding(4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(440, 35);
            txtCedula.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.TabIndex = 13;
            txtCedula.Text = "Cédula";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(69, 370);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(440, 85);
            txtDireccion.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.TabIndex = 12;
            txtDireccion.Text = "Dirección";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(69, 306);
            txtEstado.Margin = new Padding(4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(440, 35);
            txtEstado.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.TabIndex = 11;
            txtEstado.Text = "Estado";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(131, 234);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(324, 35);
            txtTelefono.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.TabIndex = 10;
            txtTelefono.Text = "Numero de telefono";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(328, 165);
            txtSegundoApellido.Margin = new Padding(4);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(194, 35);
            txtSegundoApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoApellido.TabIndex = 9;
            txtSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(41, 165);
            txtPrimerApellido.Margin = new Padding(4);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(194, 35);
            txtPrimerApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerApellido.TabIndex = 8;
            txtPrimerApellido.Text = "Primer apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(328, 101);
            txtSegundoNombre.Margin = new Padding(4);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(194, 35);
            txtSegundoNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoNombre.TabIndex = 7;
            txtSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(41, 101);
            txtPrimerNombre.Margin = new Padding(4);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(194, 35);
            txtPrimerNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerNombre.TabIndex = 6;
            txtPrimerNombre.Text = "Primer nombre";
            // 
            // txtEditarClientes
            // 
            txtEditarClientes.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEditarClientes.Location = new Point(105, 15);
            txtEditarClientes.Margin = new Padding(4);
            txtEditarClientes.Name = "txtEditarClientes";
            txtEditarClientes.ReadOnly = true;
            txtEditarClientes.Size = new Size(369, 39);
            txtEditarClientes.TabIndex = 5;
            txtEditarClientes.Text = "Editar datos del clientes";
            txtEditarClientes.TextAlign = HorizontalAlignment.Center;
            // 
            // UC_Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnDerecho);
            Controls.Add(pnIzquierdo);
            Margin = new Padding(4);
            Name = "UC_Clientes";
            Size = new Size(1250, 1029);
            ((System.ComponentModel.ISupportInitialize)pnIzquierdo).EndInit();
            pnIzquierdo.ResumeLayout(false);
            pnIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnDerecho).EndInit();
            pnDerecho.ResumeLayout(false);
            pnDerecho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnIzquierdo;
        private Krypton.Toolkit.KryptonDataGridView dtgClientes;
        private Krypton.Toolkit.KryptonPanel pnDerecho;
        private TextBox txtClientes;
        private TextBox txtEditarClientes;
        private Krypton.Toolkit.KryptonTextBox txtDireccion;
        private Krypton.Toolkit.KryptonTextBox txtEstado;
        private Krypton.Toolkit.KryptonTextBox txtTelefono;
        private Krypton.Toolkit.KryptonTextBox txtSegundoApellido;
        private Krypton.Toolkit.KryptonTextBox txtPrimerApellido;
        private Krypton.Toolkit.KryptonTextBox txtSegundoNombre;
        private Krypton.Toolkit.KryptonTextBox txtPrimerNombre;
        private Krypton.Toolkit.KryptonTextBox txtId;
        private Krypton.Toolkit.KryptonTextBox txtCedula;
        private Krypton.Toolkit.KryptonButton btnEditarCliente;
        private Krypton.Toolkit.KryptonButton btnEliminarCliente;
        private Krypton.Toolkit.KryptonButton btnAgregarCliente;
    }
}
