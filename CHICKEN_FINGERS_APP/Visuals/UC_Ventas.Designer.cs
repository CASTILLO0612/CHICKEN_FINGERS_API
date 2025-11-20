namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class UC_Ventas
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
            pnVistaProductos = new Krypton.Toolkit.KryptonPanel();
            lblCambio = new Krypton.Toolkit.KryptonLabel();
            lblEfectivo = new Krypton.Toolkit.KryptonLabel();
            txtCambio = new Krypton.Toolkit.KryptonTextBox();
            txtTotal = new Krypton.Toolkit.KryptonTextBox();
            txtEfectivo = new Krypton.Toolkit.KryptonTextBox();
            dtgProductosAComprar = new Krypton.Toolkit.KryptonDataGridView();
            txtNombreUsuario = new Krypton.Toolkit.KryptonTextBox();
            cbMetodoPago = new Krypton.Toolkit.KryptonComboBox();
            pbAgregarCliente = new FontAwesome.Sharp.IconPictureBox();
            pnBotones = new Krypton.Toolkit.KryptonPanel();
            btnPagar = new Krypton.Toolkit.KryptonButton();
            btnAgregarProducto = new Krypton.Toolkit.KryptonButton();
            pnVentaSuperior = new Krypton.Toolkit.KryptonPanel();
            txtCantidad = new Krypton.Toolkit.KryptonTextBox();
            cbCategoria = new Krypton.Toolkit.KryptonComboBox();
            pnDataProductos = new Krypton.Toolkit.KryptonPanel();
            dtgProductos = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)pnVistaProductos).BeginInit();
            pnVistaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProductosAComprar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbMetodoPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAgregarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnBotones).BeginInit();
            pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnVentaSuperior).BeginInit();
            pnVentaSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnDataProductos).BeginInit();
            pnDataProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            SuspendLayout();
            // 
            // pnVistaProductos
            // 
            pnVistaProductos.Controls.Add(lblCambio);
            pnVistaProductos.Controls.Add(lblEfectivo);
            pnVistaProductos.Controls.Add(txtCambio);
            pnVistaProductos.Controls.Add(txtTotal);
            pnVistaProductos.Controls.Add(txtEfectivo);
            pnVistaProductos.Controls.Add(dtgProductosAComprar);
            pnVistaProductos.Controls.Add(txtNombreUsuario);
            pnVistaProductos.Controls.Add(cbMetodoPago);
            pnVistaProductos.Controls.Add(pbAgregarCliente);
            pnVistaProductos.Controls.Add(pnBotones);
            pnVistaProductos.Dock = DockStyle.Right;
            pnVistaProductos.Location = new Point(566, 0);
            pnVistaProductos.Name = "pnVistaProductos";
            pnVistaProductos.Size = new Size(334, 523);
            pnVistaProductos.TabIndex = 0;
            // 
            // lblCambio
            // 
            lblCambio.Location = new Point(173, 371);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(64, 24);
            lblCambio.StateCommon.LongText.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCambio.StateNormal.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambio.TabIndex = 9;
            lblCambio.Values.Text = "Cambio";
            // 
            // lblEfectivo
            // 
            lblEfectivo.Location = new Point(6, 371);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(126, 24);
            lblEfectivo.StateCommon.LongText.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEfectivo.StateNormal.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEfectivo.TabIndex = 8;
            lblEfectivo.Values.Text = "Efectivo de pago";
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(163, 401);
            txtCambio.Name = "txtCambio";
            txtCambio.ReadOnly = true;
            txtCambio.Size = new Size(151, 31);
            txtCambio.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCambio.TabIndex = 7;
            txtCambio.Text = "Cambio";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(187, 45);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(141, 31);
            txtTotal.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.TabIndex = 6;
            txtTotal.Text = "Total";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(6, 401);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(151, 31);
            txtEfectivo.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEfectivo.TabIndex = 5;
            txtEfectivo.Text = "Ingresar efectivo";
            // 
            // dtgProductosAComprar
            // 
            dtgProductosAComprar.BorderStyle = BorderStyle.None;
            dtgProductosAComprar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductosAComprar.Location = new Point(3, 80);
            dtgProductosAComprar.Name = "dtgProductosAComprar";
            dtgProductosAComprar.RowHeadersWidth = 51;
            dtgProductosAComprar.Size = new Size(325, 282);
            dtgProductosAComprar.TabIndex = 4;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(6, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(201, 31);
            txtNombreUsuario.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.TabIndex = 3;
            txtNombreUsuario.Text = "Nombre del cliente";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.DropDownWidth = 245;
            cbMetodoPago.Location = new Point(6, 45);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(164, 29);
            cbMetodoPago.StateCommon.ComboBox.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMetodoPago.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbMetodoPago.TabIndex = 2;
            cbMetodoPago.Text = "MétodoPago";
            // 
            // pbAgregarCliente
            // 
            pbAgregarCliente.BackColor = SystemColors.Control;
            pbAgregarCliente.ForeColor = SystemColors.ControlText;
            pbAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            pbAgregarCliente.IconColor = SystemColors.ControlText;
            pbAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbAgregarCliente.IconSize = 40;
            pbAgregarCliente.Location = new Point(291, 3);
            pbAgregarCliente.Name = "pbAgregarCliente";
            pbAgregarCliente.Size = new Size(40, 40);
            pbAgregarCliente.TabIndex = 1;
            pbAgregarCliente.TabStop = false;
            pbAgregarCliente.Click += pbAgregarCliente_Click;
            // 
            // pnBotones
            // 
            pnBotones.Controls.Add(btnPagar);
            pnBotones.Controls.Add(btnAgregarProducto);
            pnBotones.Dock = DockStyle.Bottom;
            pnBotones.Location = new Point(0, 438);
            pnBotones.Name = "pnBotones";
            pnBotones.Size = new Size(334, 85);
            pnBotones.TabIndex = 0;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(163, 3);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(171, 74);
            btnPagar.TabIndex = 1;
            btnPagar.Values.DropDownArrowColor = Color.Empty;
            btnPagar.Values.Text = "Proceder al pago";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(0, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(157, 74);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Values.DropDownArrowColor = Color.Empty;
            btnAgregarProducto.Values.Text = "Agregar Producto";
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // pnVentaSuperior
            // 
            pnVentaSuperior.Controls.Add(txtCantidad);
            pnVentaSuperior.Controls.Add(cbCategoria);
            pnVentaSuperior.Dock = DockStyle.Top;
            pnVentaSuperior.Location = new Point(0, 0);
            pnVentaSuperior.Name = "pnVentaSuperior";
            pnVentaSuperior.Size = new Size(566, 60);
            pnVentaSuperior.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(324, 13);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(201, 31);
            txtCantidad.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.TabIndex = 4;
            txtCantidad.Text = "Cantidad";
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownWidth = 245;
            cbCategoria.Location = new Point(26, 15);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(245, 29);
            cbCategoria.StateCommon.ComboBox.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategoria.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbCategoria.StateNormal.ComboBox.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategoria.TabIndex = 0;
            cbCategoria.Text = "Categorias";
            // 
            // pnDataProductos
            // 
            pnDataProductos.Controls.Add(dtgProductos);
            pnDataProductos.Dock = DockStyle.Fill;
            pnDataProductos.Location = new Point(0, 60);
            pnDataProductos.Name = "pnDataProductos";
            pnDataProductos.Size = new Size(566, 463);
            pnDataProductos.TabIndex = 2;
            // 
            // dtgProductos
            // 
            dtgProductos.AllowUserToAddRows = false;
            dtgProductos.AllowUserToDeleteRows = false;
            dtgProductos.AllowUserToResizeColumns = false;
            dtgProductos.AllowUserToResizeRows = false;
            dtgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProductos.BorderStyle = BorderStyle.None;
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductos.Location = new Point(0, 0);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.ReadOnly = true;
            dtgProductos.RowHeadersWidth = 51;
            dtgProductos.Size = new Size(566, 460);
            dtgProductos.TabIndex = 0;
            // 
            // UC_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnDataProductos);
            Controls.Add(pnVentaSuperior);
            Controls.Add(pnVistaProductos);
            Name = "UC_Ventas";
            Size = new Size(900, 523);
            ((System.ComponentModel.ISupportInitialize)pnVistaProductos).EndInit();
            pnVistaProductos.ResumeLayout(false);
            pnVistaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProductosAComprar).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbMetodoPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAgregarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnBotones).EndInit();
            pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnVentaSuperior).EndInit();
            pnVentaSuperior.ResumeLayout(false);
            pnVentaSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnDataProductos).EndInit();
            pnDataProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnVistaProductos;
        private Krypton.Toolkit.KryptonPanel pnBotones;
        private Krypton.Toolkit.KryptonPanel pnVentaSuperior;
        private Krypton.Toolkit.KryptonComboBox cbCategoria;
        private Krypton.Toolkit.KryptonPanel pnDataProductos;
        private Krypton.Toolkit.KryptonTextBox txtNombreUsuario;
        private Krypton.Toolkit.KryptonComboBox cbMetodoPago;
        private FontAwesome.Sharp.IconPictureBox pbAgregarCliente;
        private Krypton.Toolkit.KryptonDataGridView dtgProductos;
        private Krypton.Toolkit.KryptonDataGridView dtgProductosAComprar;
        private Krypton.Toolkit.KryptonButton btnPagar;
        private Krypton.Toolkit.KryptonButton btnAgregarProducto;
        private Krypton.Toolkit.KryptonTextBox txtCambio;
        private Krypton.Toolkit.KryptonTextBox txtTotal;
        protected Krypton.Toolkit.KryptonTextBox txtEfectivo;
        private Krypton.Toolkit.KryptonTextBox txtCantidad;
        private Krypton.Toolkit.KryptonLabel lblCambio;
        private Krypton.Toolkit.KryptonLabel lblEfectivo;
    }
}
