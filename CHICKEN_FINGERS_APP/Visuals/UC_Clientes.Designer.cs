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
            txtId = new Krypton.Toolkit.KryptonTextBox();
            txtCedula = new Krypton.Toolkit.KryptonTextBox();
            txtDireccion = new Krypton.Toolkit.KryptonTextBox();
            txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            txtTelefono = new Krypton.Toolkit.KryptonTextBox();
            txtSegundoApellido = new Krypton.Toolkit.KryptonTextBox();
            txtPrimerApellido = new Krypton.Toolkit.KryptonTextBox();
            txtSegundoNombre = new Krypton.Toolkit.KryptonTextBox();
            txtPrimerNombre = new Krypton.Toolkit.KryptonTextBox();
            txtEditarClientes = new TextBox();
            btnEliminarCliente = new Krypton.Toolkit.KryptonButton();
            btnEditarCliente = new Krypton.Toolkit.KryptonButton();
            btnAgregarCliente = new Krypton.Toolkit.KryptonButton();
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
            pnIzquierdo.Name = "pnIzquierdo";
            pnIzquierdo.Size = new Size(1000, 823);
            pnIzquierdo.TabIndex = 0;
            // 
            // txtClientes
            // 
            txtClientes.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClientes.Location = new Point(89, 9);
            txtClientes.Name = "txtClientes";
            txtClientes.ReadOnly = true;
            txtClientes.Size = new Size(296, 34);
            txtClientes.TabIndex = 4;
            txtClientes.Text = "Clientes registrados";
            txtClientes.TextAlign = HorizontalAlignment.Center;
            // 
            // dtgClientes
            // 
            dtgClientes.BorderStyle = BorderStyle.None;
            dtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientes.Location = new Point(3, 49);
            dtgClientes.Name = "dtgClientes";
            dtgClientes.RowHeadersWidth = 51;
            dtgClientes.Size = new Size(517, 706);
            dtgClientes.TabIndex = 0;
            // 
            // pnDerecho
            // 
            pnDerecho.Controls.Add(btnAgregarCliente);
            pnDerecho.Controls.Add(btnEditarCliente);
            pnDerecho.Controls.Add(btnEliminarCliente);
            pnDerecho.Controls.Add(txtId);
            pnDerecho.Controls.Add(txtCedula);
            pnDerecho.Controls.Add(txtDireccion);
            pnDerecho.Controls.Add(txtCorreo);
            pnDerecho.Controls.Add(txtTelefono);
            pnDerecho.Controls.Add(txtSegundoApellido);
            pnDerecho.Controls.Add(txtPrimerApellido);
            pnDerecho.Controls.Add(txtSegundoNombre);
            pnDerecho.Controls.Add(txtPrimerNombre);
            pnDerecho.Controls.Add(txtEditarClientes);
            pnDerecho.Dock = DockStyle.Right;
            pnDerecho.Location = new Point(526, 0);
            pnDerecho.Name = "pnDerecho";
            pnDerecho.Size = new Size(474, 823);
            pnDerecho.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(194, 107);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(62, 31);
            txtId.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.TabIndex = 14;
            txtId.Text = "Id";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(55, 380);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(352, 31);
            txtCedula.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.TabIndex = 13;
            txtCedula.Text = "Cédula";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(55, 296);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(352, 68);
            txtDireccion.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.TabIndex = 12;
            txtDireccion.Text = "Dirección";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(55, 245);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(352, 31);
            txtCorreo.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.TabIndex = 11;
            txtCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(105, 187);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(259, 31);
            txtTelefono.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.TabIndex = 10;
            txtTelefono.Text = "Numero de telefono";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(262, 132);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(155, 31);
            txtSegundoApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoApellido.TabIndex = 9;
            txtSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(33, 132);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(155, 31);
            txtPrimerApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerApellido.TabIndex = 8;
            txtPrimerApellido.Text = "Primer apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(262, 81);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(155, 31);
            txtSegundoNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoNombre.TabIndex = 7;
            txtSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(33, 81);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(155, 31);
            txtPrimerNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerNombre.TabIndex = 6;
            txtPrimerNombre.Text = "Primer nombre";
            // 
            // txtEditarClientes
            // 
            txtEditarClientes.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEditarClientes.Location = new Point(84, 12);
            txtEditarClientes.Name = "txtEditarClientes";
            txtEditarClientes.ReadOnly = true;
            txtEditarClientes.Size = new Size(296, 34);
            txtEditarClientes.TabIndex = 5;
            txtEditarClientes.Text = "Editar datos del clientes";
            txtEditarClientes.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(55, 469);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(169, 63);
            btnEliminarCliente.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarCliente.TabIndex = 15;
            btnEliminarCliente.Values.DropDownArrowColor = Color.Empty;
            btnEliminarCliente.Values.Text = "Eliminar cliente";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(262, 469);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(169, 63);
            btnEditarCliente.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarCliente.TabIndex = 16;
            btnEditarCliente.Values.DropDownArrowColor = Color.Empty;
            btnEditarCliente.Values.Text = "Editar cliente";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(160, 565);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(169, 63);
            btnAgregarCliente.StateCommon.Content.ShortText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCliente.TabIndex = 17;
            btnAgregarCliente.Values.DropDownArrowColor = Color.Empty;
            btnAgregarCliente.Values.Text = "Agregar Cliente";
            // 
            // UC_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnDerecho);
            Controls.Add(pnIzquierdo);
            Name = "UC_Clientes";
            Size = new Size(1000, 823);
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
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
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
