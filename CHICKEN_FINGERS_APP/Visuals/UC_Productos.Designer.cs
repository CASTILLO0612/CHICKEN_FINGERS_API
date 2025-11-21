namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class UC_Productos
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
            dtgCategorias = new Krypton.Toolkit.KryptonDataGridView();
            txtCategorias = new TextBox();
            dtgProductos = new Krypton.Toolkit.KryptonDataGridView();
            txtProductos = new TextBox();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            txtCodigoProducto = new Krypton.Toolkit.KryptonTextBox();
            txtPrecioUnitario = new Krypton.Toolkit.KryptonTextBox();
            btnAgregarCategoria = new Krypton.Toolkit.KryptonButton();
            btnEditarCategoria = new Krypton.Toolkit.KryptonButton();
            btnEliminarCategoria = new Krypton.Toolkit.KryptonButton();
            txtIdCategoria = new Krypton.Toolkit.KryptonTextBox();
            txtNombreCategoria = new Krypton.Toolkit.KryptonTextBox();
            txtEditarCategorias = new TextBox();
            btnAgregarProducto = new Krypton.Toolkit.KryptonButton();
            btnEditarProducto = new Krypton.Toolkit.KryptonButton();
            txtIdProducto = new Krypton.Toolkit.KryptonTextBox();
            btnEliminarProducto = new Krypton.Toolkit.KryptonButton();
            cbCategoria = new Krypton.Toolkit.KryptonComboBox();
            txtEditarProducto = new TextBox();
            txtNombreProducto = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbCategoria).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(dtgCategorias);
            kryptonPanel1.Controls.Add(txtCategorias);
            kryptonPanel1.Controls.Add(dtgProductos);
            kryptonPanel1.Controls.Add(txtProductos);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(535, 823);
            kryptonPanel1.TabIndex = 0;
            // 
            // dtgCategorias
            // 
            dtgCategorias.BorderStyle = BorderStyle.None;
            dtgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCategorias.Location = new Point(67, 444);
            dtgCategorias.Name = "dtgCategorias";
            dtgCategorias.RowHeadersWidth = 51;
            dtgCategorias.Size = new Size(415, 299);
            dtgCategorias.TabIndex = 6;
            dtgCategorias.CellClick += dtgCategorias_CellClick;
            // 
            // txtCategorias
            // 
            txtCategorias.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategorias.Location = new Point(80, 404);
            txtCategorias.Name = "txtCategorias";
            txtCategorias.ReadOnly = true;
            txtCategorias.Size = new Size(296, 34);
            txtCategorias.TabIndex = 5;
            txtCategorias.Text = "Categorias";
            txtCategorias.TextAlign = HorizontalAlignment.Center;
            // 
            // dtgProductos
            // 
            dtgProductos.AllowUserToAddRows = false;
            dtgProductos.AllowUserToDeleteRows = false;
            dtgProductos.BorderStyle = BorderStyle.None;
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductos.Location = new Point(3, 67);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.ReadOnly = true;
            dtgProductos.RowHeadersWidth = 51;
            dtgProductos.Size = new Size(479, 288);
            dtgProductos.TabIndex = 4;
            dtgProductos.CellClick += dtgProductos_CellClick;
            // 
            // txtProductos
            // 
            txtProductos.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductos.Location = new Point(80, 3);
            txtProductos.Name = "txtProductos";
            txtProductos.ReadOnly = true;
            txtProductos.Size = new Size(296, 34);
            txtProductos.TabIndex = 3;
            txtProductos.Text = "Productos";
            txtProductos.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(txtCodigoProducto);
            kryptonPanel2.Controls.Add(txtPrecioUnitario);
            kryptonPanel2.Controls.Add(btnAgregarCategoria);
            kryptonPanel2.Controls.Add(btnEditarCategoria);
            kryptonPanel2.Controls.Add(btnEliminarCategoria);
            kryptonPanel2.Controls.Add(txtIdCategoria);
            kryptonPanel2.Controls.Add(txtNombreCategoria);
            kryptonPanel2.Controls.Add(txtEditarCategorias);
            kryptonPanel2.Controls.Add(btnAgregarProducto);
            kryptonPanel2.Controls.Add(btnEditarProducto);
            kryptonPanel2.Controls.Add(txtIdProducto);
            kryptonPanel2.Controls.Add(btnEliminarProducto);
            kryptonPanel2.Controls.Add(cbCategoria);
            kryptonPanel2.Controls.Add(txtEditarProducto);
            kryptonPanel2.Controls.Add(txtNombreProducto);
            kryptonPanel2.Dock = DockStyle.Right;
            kryptonPanel2.Location = new Point(532, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(468, 823);
            kryptonPanel2.TabIndex = 1;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(251, 128);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(196, 31);
            txtCodigoProducto.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoProducto.TabIndex = 33;
            txtCodigoProducto.Text = "Código producto";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(34, 128);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(196, 31);
            txtPrecioUnitario.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioUnitario.TabIndex = 32;
            txtPrecioUnitario.Text = "Precio unitario";
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(159, 565);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(155, 42);
            btnAgregarCategoria.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCategoria.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCategoria.TabIndex = 31;
            btnAgregarCategoria.Values.DropDownArrowColor = Color.Empty;
            btnAgregarCategoria.Values.Text = "Agregar categoria";
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Location = new Point(251, 613);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(155, 42);
            btnEditarCategoria.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarCategoria.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarCategoria.TabIndex = 30;
            btnEditarCategoria.Values.DropDownArrowColor = Color.Empty;
            btnEditarCategoria.Values.Text = "Editar categoria";
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Location = new Point(75, 613);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(155, 42);
            btnEliminarCategoria.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarCategoria.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarCategoria.TabIndex = 29;
            btnEliminarCategoria.Values.DropDownArrowColor = Color.Empty;
            btnEliminarCategoria.Values.Text = "Eliminar categoria";
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(49, 490);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.ReadOnly = true;
            txtIdCategoria.Size = new Size(68, 31);
            txtIdCategoria.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCategoria.TabIndex = 28;
            txtIdCategoria.Text = "Id";
            txtIdCategoria.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(49, 453);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(387, 31);
            txtNombreCategoria.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCategoria.TabIndex = 27;
            txtNombreCategoria.Text = "Nombre de la categoria";
            // 
            // txtEditarCategorias
            // 
            txtEditarCategorias.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEditarCategorias.Location = new Point(92, 404);
            txtEditarCategorias.Name = "txtEditarCategorias";
            txtEditarCategorias.ReadOnly = true;
            txtEditarCategorias.Size = new Size(296, 34);
            txtEditarCategorias.TabIndex = 26;
            txtEditarCategorias.Text = "Editar categorias";
            txtEditarCategorias.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(159, 275);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(155, 42);
            btnAgregarProducto.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.TabIndex = 25;
            btnAgregarProducto.Values.DropDownArrowColor = Color.Empty;
            btnAgregarProducto.Values.Text = "Agregar producto";
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(251, 227);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(155, 42);
            btnEditarProducto.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarProducto.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarProducto.TabIndex = 24;
            btnEditarProducto.Values.DropDownArrowColor = Color.Empty;
            btnEditarProducto.Values.Text = "Editar producto";
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(277, 181);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(68, 31);
            txtIdProducto.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.TabIndex = 23;
            txtIdProducto.Text = "Id";
            txtIdProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(62, 227);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(155, 42);
            btnEliminarProducto.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarProducto.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarProducto.TabIndex = 22;
            btnEliminarProducto.Values.DropDownArrowColor = Color.Empty;
            btnEliminarProducto.Values.Text = "Eliminar producto";
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownWidth = 210;
            cbCategoria.Location = new Point(37, 181);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(210, 29);
            cbCategoria.StateCommon.ComboBox.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategoria.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbCategoria.TabIndex = 21;
            cbCategoria.Text = "Categoria";
            // 
            // txtEditarProducto
            // 
            txtEditarProducto.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEditarProducto.Location = new Point(92, 3);
            txtEditarProducto.Name = "txtEditarProducto";
            txtEditarProducto.ReadOnly = true;
            txtEditarProducto.Size = new Size(296, 34);
            txtEditarProducto.TabIndex = 20;
            txtEditarProducto.Text = "Editar productos";
            txtEditarProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(37, 70);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(387, 31);
            txtNombreProducto.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProducto.TabIndex = 15;
            txtNombreProducto.Text = "Nombre del producto";
            // 
            // UC_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "UC_Productos";
            Size = new Size(1000, 823);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private TextBox txtProductos;
        private Krypton.Toolkit.KryptonDataGridView dtgCategorias;
        private TextBox txtCategorias;
        private Krypton.Toolkit.KryptonDataGridView dtgProductos;
        private TextBox txtEditarProducto;
        private Krypton.Toolkit.KryptonTextBox txtSegundoApellido;
        private Krypton.Toolkit.KryptonTextBox txtPrimerApellido;
        private Krypton.Toolkit.KryptonTextBox txtSegundoNombre;
        private Krypton.Toolkit.KryptonTextBox txtNombreProducto;
        private Krypton.Toolkit.KryptonComboBox cbCategoria;
        private Krypton.Toolkit.KryptonButton btnEliminarProducto;
        private Krypton.Toolkit.KryptonButton btnEditarProducto;
        private Krypton.Toolkit.KryptonTextBox txtIdProducto;
        private Krypton.Toolkit.KryptonTextBox txtNombreCategoria;
        private TextBox txtEditarCategorias;
        private Krypton.Toolkit.KryptonButton btnAgregarProducto;
        private Krypton.Toolkit.KryptonTextBox txtIdCategoria;
        private Krypton.Toolkit.KryptonButton btnAgregarCategoria;
        private Krypton.Toolkit.KryptonButton btnEditarCategoria;
        private Krypton.Toolkit.KryptonButton btnEliminarCategoria;
        private Krypton.Toolkit.KryptonTextBox txtPrecioUnitario;
        private Krypton.Toolkit.KryptonTextBox txtCodigoProducto;
    }
}
