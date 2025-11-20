namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class UC_Historial
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
            txtPedidos = new TextBox();
            txtDetalles = new TextBox();
            btnEliminarDetalle = new FontAwesome.Sharp.IconButton();
            btnEliminarPedido = new FontAwesome.Sharp.IconButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            dtgDetalles = new Krypton.Toolkit.KryptonDataGridView();
            dtgPedidos = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPedidos
            // 
            txtPedidos.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPedidos.Location = new Point(81, 12);
            txtPedidos.Name = "txtPedidos";
            txtPedidos.ReadOnly = true;
            txtPedidos.Size = new Size(296, 34);
            txtPedidos.TabIndex = 2;
            txtPedidos.Text = "Pedidos";
            txtPedidos.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDetalles
            // 
            txtDetalles.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDetalles.Location = new Point(60, 12);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.ReadOnly = true;
            txtDetalles.Size = new Size(296, 34);
            txtDetalles.TabIndex = 3;
            txtDetalles.Text = "Detalles de los pedidos";
            txtDetalles.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEliminarDetalle
            // 
            btnEliminarDetalle.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminarDetalle.IconColor = Color.Black;
            btnEliminarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarDetalle.Location = new Point(228, 372);
            btnEliminarDetalle.Name = "btnEliminarDetalle";
            btnEliminarDetalle.Size = new Size(158, 64);
            btnEliminarDetalle.TabIndex = 4;
            btnEliminarDetalle.Text = "Eliminar detalle";
            btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarPedido.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminarPedido.IconColor = Color.Black;
            btnEliminarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarPedido.Location = new Point(60, 372);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(158, 64);
            btnEliminarPedido.TabIndex = 5;
            btnEliminarPedido.Text = "Eliminar pedido";
            btnEliminarPedido.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(dtgPedidos);
            kryptonPanel1.Controls.Add(txtPedidos);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(516, 523);
            kryptonPanel1.TabIndex = 6;
            // 
            // dtgDetalles
            // 
            dtgDetalles.BorderStyle = BorderStyle.None;
            dtgDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDetalles.Location = new Point(3, 71);
            dtgDetalles.Name = "dtgDetalles";
            dtgDetalles.RowHeadersWidth = 51;
            dtgDetalles.Size = new Size(397, 230);
            dtgDetalles.TabIndex = 7;
            // 
            // dtgPedidos
            // 
            dtgPedidos.AllowUserToAddRows = false;
            dtgPedidos.AllowUserToDeleteRows = false;
            dtgPedidos.BorderStyle = BorderStyle.None;
            dtgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedidos.Location = new Point(3, 71);
            dtgPedidos.Name = "dtgPedidos";
            dtgPedidos.ReadOnly = true;
            dtgPedidos.RowHeadersWidth = 51;
            dtgPedidos.Size = new Size(470, 429);
            dtgPedidos.TabIndex = 6;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(dtgDetalles);
            kryptonPanel2.Controls.Add(txtDetalles);
            kryptonPanel2.Controls.Add(btnEliminarDetalle);
            kryptonPanel2.Controls.Add(btnEliminarPedido);
            kryptonPanel2.Dock = DockStyle.Right;
            kryptonPanel2.Location = new Point(494, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(410, 523);
            kryptonPanel2.TabIndex = 7;
            // 
            // UC_Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "UC_Historial";
            Size = new Size(904, 523);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPedidos;
        private TextBox txtDetalles;
        private FontAwesome.Sharp.IconButton btnEliminarDetalle;
        private FontAwesome.Sharp.IconButton btnEliminarPedido;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView dtgDetalles;
        private Krypton.Toolkit.KryptonDataGridView dtgPedidos;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}
