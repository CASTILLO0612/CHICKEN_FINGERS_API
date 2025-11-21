
namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnNavegacion = new Krypton.Toolkit.KryptonPanel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnHistorial = new FontAwesome.Sharp.IconButton();
            btnVentas = new FontAwesome.Sharp.IconButton();
            pnPrincipal = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)pnNavegacion).BeginInit();
            pnNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnPrincipal).BeginInit();
            SuspendLayout();
            // 
            // pnNavegacion
            // 
            pnNavegacion.Controls.Add(btnCerrar);
            pnNavegacion.Controls.Add(btnReportes);
            pnNavegacion.Controls.Add(btnProductos);
            pnNavegacion.Controls.Add(btnClientes);
            pnNavegacion.Controls.Add(btnHistorial);
            pnNavegacion.Controls.Add(btnVentas);
            pnNavegacion.Dock = DockStyle.Left;
            pnNavegacion.Location = new Point(0, 0);
            pnNavegacion.Name = "pnNavegacion";
            pnNavegacion.Size = new Size(113, 823);
            pnNavegacion.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.AutoSize = true;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCerrar.IconColor = Color.Red;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.Location = new Point(-1, 741);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(114, 82);
            btnCerrar.TabIndex = 5;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = true;
            btnReportes.BackColor = Color.Transparent;
            btnReportes.BackgroundImageLayout = ImageLayout.Stretch;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.Location = new Point(0, 313);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(113, 82);
            btnReportes.TabIndex = 4;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnProductos
            // 
            btnProductos.AutoSize = true;
            btnProductos.BackColor = Color.Transparent;
            btnProductos.BackgroundImageLayout = ImageLayout.Stretch;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.Burger;
            btnProductos.IconColor = Color.Black;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.Location = new Point(-1, 235);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(114, 82);
            btnProductos.TabIndex = 3;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.AutoSize = true;
            btnClientes.BackColor = Color.Transparent;
            btnClientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            btnClientes.IconColor = Color.Black;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.Location = new Point(0, 156);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(113, 82);
            btnClientes.TabIndex = 2;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.AutoSize = true;
            btnHistorial.BackColor = Color.Transparent;
            btnHistorial.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistorial.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnHistorial.IconColor = Color.Black;
            btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistorial.Location = new Point(-1, 79);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(114, 82);
            btnHistorial.TabIndex = 1;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnVentas
            // 
            btnVentas.AutoSize = true;
            btnVentas.BackColor = Color.Transparent;
            btnVentas.BackgroundImageLayout = ImageLayout.Stretch;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            btnVentas.IconColor = Color.Black;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.Location = new Point(0, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(113, 82);
            btnVentas.TabIndex = 0;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // pnPrincipal
            // 
            pnPrincipal.Dock = DockStyle.Fill;
            pnPrincipal.Location = new Point(113, 0);
            pnPrincipal.Name = "pnPrincipal";
            pnPrincipal.Size = new Size(887, 823);
            pnPrincipal.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 823);
            Controls.Add(pnPrincipal);
            Controls.Add(pnNavegacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pnNavegacion).EndInit();
            pnNavegacion.ResumeLayout(false);
            pnNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnPrincipal).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Krypton.Toolkit.KryptonPanel pnNavegacion;
        private Krypton.Toolkit.KryptonPanel pnPrincipal;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}