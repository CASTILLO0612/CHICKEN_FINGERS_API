namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class UC_AgregarCliente
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
            btnAñadirCliente = new FontAwesome.Sharp.IconButton();
            txtCedula = new Krypton.Toolkit.KryptonTextBox();
            txtDireccion = new Krypton.Toolkit.KryptonTextBox();
            txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            txtTelefono = new Krypton.Toolkit.KryptonTextBox();
            txtSegundoApellido = new Krypton.Toolkit.KryptonTextBox();
            txtPrimerApellido = new Krypton.Toolkit.KryptonTextBox();
            txtSegundoNombre = new Krypton.Toolkit.KryptonTextBox();
            txtPrimerNombre = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnAñadirCliente);
            kryptonPanel1.Controls.Add(txtCedula);
            kryptonPanel1.Controls.Add(txtDireccion);
            kryptonPanel1.Controls.Add(txtCorreo);
            kryptonPanel1.Controls.Add(txtTelefono);
            kryptonPanel1.Controls.Add(txtSegundoApellido);
            kryptonPanel1.Controls.Add(txtPrimerApellido);
            kryptonPanel1.Controls.Add(txtSegundoNombre);
            kryptonPanel1.Controls.Add(txtPrimerNombre);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(443, 406);
            kryptonPanel1.TabIndex = 0;
            kryptonPanel1.Paint += kryptonPanel1_Paint;
            // 
            // btnAñadirCliente
            // 
            btnAñadirCliente.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadirCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAñadirCliente.IconColor = Color.Black;
            btnAñadirCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAñadirCliente.Location = new Point(150, 349);
            btnAñadirCliente.Name = "btnAñadirCliente";
            btnAñadirCliente.Size = new Size(169, 45);
            btnAñadirCliente.TabIndex = 27;
            btnAñadirCliente.Text = "Añadir";
            btnAñadirCliente.UseVisualStyleBackColor = true;
            btnAñadirCliente.Click += btnAñadirCliente_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(37, 309);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(352, 31);
            txtCedula.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.TabIndex = 25;
            txtCedula.Text = "Cédula";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(37, 225);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(352, 68);
            txtDireccion.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.TabIndex = 24;
            txtDireccion.Text = "Dirección";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(37, 174);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(352, 31);
            txtCorreo.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.TabIndex = 23;
            txtCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(87, 116);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(259, 31);
            txtTelefono.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.TabIndex = 22;
            txtTelefono.Text = "Numero de telefono";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(244, 61);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(155, 31);
            txtSegundoApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoApellido.TabIndex = 21;
            txtSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(15, 61);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(155, 31);
            txtPrimerApellido.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerApellido.TabIndex = 20;
            txtPrimerApellido.Text = "Primer apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(244, 10);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(155, 31);
            txtSegundoNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoNombre.TabIndex = 19;
            txtSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(15, 10);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(155, 31);
            txtPrimerNombre.StateCommon.Content.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerNombre.TabIndex = 18;
            txtPrimerNombre.Text = "Primer nombre";
            // 
            // UC_AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "UC_AgregarCliente";
            Size = new Size(443, 406);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private FontAwesome.Sharp.IconButton btnAñadirCliente;
        private Krypton.Toolkit.KryptonTextBox txtCedula;
        private Krypton.Toolkit.KryptonTextBox txtDireccion;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private Krypton.Toolkit.KryptonTextBox txtTelefono;
        private Krypton.Toolkit.KryptonTextBox txtSegundoApellido;
        private Krypton.Toolkit.KryptonTextBox txtPrimerApellido;
        private Krypton.Toolkit.KryptonTextBox txtSegundoNombre;
        private Krypton.Toolkit.KryptonTextBox txtPrimerNombre;
    }
}
