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
            btnActualizarCliente = new FontAwesome.Sharp.IconButton();
            btnEliminarCliente = new FontAwesome.Sharp.IconButton();
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
            btnAñadirCliente = new FontAwesome.Sharp.IconButton();
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
            pnIzquierdo.Dock = DockStyle.Left;
            pnIzquierdo.Location = new Point(0, 0);
            pnIzquierdo.Name = "pnIzquierdo";
            pnIzquierdo.Size = new Size(466, 523);
            pnIzquierdo.TabIndex = 0;
            // 
            // txtClientes
            // 
            txtClientes.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClientes.Location = new Point(73, 9);
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
            dtgClientes.Size = new Size(460, 368);
            dtgClientes.TabIndex = 0;
            // 
            // pnDerecho
            // 
            pnDerecho.Controls.Add(btnAñadirCliente);
            pnDerecho.Controls.Add(btnActualizarCliente);
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
            pnDerecho.Location = new Point(461, 0);
            pnDerecho.Name = "pnDerecho";
            pnDerecho.Size = new Size(439, 523);
            pnDerecho.TabIndex = 1;
            // 
            // btnActualizarCliente
            // 
            btnActualizarCliente.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnActualizarCliente.IconColor = Color.Black;
            btnActualizarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizarCliente.Location = new Point(175, 417);
            btnActualizarCliente.Name = "btnActualizarCliente";
            btnActualizarCliente.Size = new Size(167, 59);
            btnActualizarCliente.TabIndex = 16;
            btnActualizarCliente.Text = "Actualizar cliente";
            btnActualizarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminarCliente.IconColor = Color.Black;
            btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarCliente.Location = new Point(19, 417);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(147, 61);
            btnEliminarCliente.TabIndex = 15;
            btnEliminarCliente.Text = "Eliminar cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 104);
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
            txtCedula.Location = new Point(33, 377);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(352, 31);
            txtCedula.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.TabIndex = 13;
            txtCedula.Text = "Cédula";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(33, 293);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(352, 68);
            txtDireccion.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.TabIndex = 12;
            txtDireccion.Text = "Dirección";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(33, 242);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(352, 31);
            txtCorreo.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.TabIndex = 11;
            txtCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(83, 184);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(259, 31);
            txtTelefono.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.TabIndex = 10;
            txtTelefono.Text = "Numero de telefono";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(240, 129);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(155, 31);
            txtSegundoApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoApellido.TabIndex = 9;
            txtSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(11, 129);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(155, 31);
            txtPrimerApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerApellido.TabIndex = 8;
            txtPrimerApellido.Text = "Primer apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(240, 78);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(155, 31);
            txtSegundoNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoNombre.TabIndex = 7;
            txtSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(11, 78);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(155, 31);
            txtPrimerNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerNombre.TabIndex = 6;
            txtPrimerNombre.Text = "Primer nombre";
            // 
            // txtEditarClientes
            // 
            txtEditarClientes.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEditarClientes.Location = new Point(62, 9);
            txtEditarClientes.Name = "txtEditarClientes";
            txtEditarClientes.ReadOnly = true;
            txtEditarClientes.Size = new Size(296, 34);
            txtEditarClientes.TabIndex = 5;
            txtEditarClientes.Text = "Editar datos del clientes";
            txtEditarClientes.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAñadirCliente
            // 
            btnAñadirCliente.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadirCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAñadirCliente.IconColor = Color.Black;
            btnAñadirCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAñadirCliente.Location = new Point(348, 417);
            btnAñadirCliente.Name = "btnAñadirCliente";
            btnAñadirCliente.Size = new Size(88, 57);
            btnAñadirCliente.TabIndex = 17;
            btnAñadirCliente.Text = "Añadir";
            btnAñadirCliente.UseVisualStyleBackColor = true;
            // 
            // UC_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnDerecho);
            Controls.Add(pnIzquierdo);
            Name = "UC_Clientes";
            Size = new Size(900, 523);
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
        private FontAwesome.Sharp.IconButton btnActualizarCliente;
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
        private FontAwesome.Sharp.IconButton btnAñadirCliente;
    }
}
