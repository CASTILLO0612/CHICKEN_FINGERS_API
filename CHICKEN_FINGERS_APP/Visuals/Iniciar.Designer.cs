namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class Iniciar
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            pbEye = new FontAwesome.Sharp.IconPictureBox();
            btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            lblPassword = new Krypton.Toolkit.KryptonLabel();
            txtContraseña = new Krypton.Toolkit.KryptonTextBox();
            lblUser = new Krypton.Toolkit.KryptonLabel();
            txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnSalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnSalir);
            kryptonPanel1.Controls.Add(pbEye);
            kryptonPanel1.Controls.Add(btnIniciarSesion);
            kryptonPanel1.Controls.Add(lblPassword);
            kryptonPanel1.Controls.Add(txtContraseña);
            kryptonPanel1.Controls.Add(lblUser);
            kryptonPanel1.Controls.Add(txtUsuario);
            kryptonPanel1.Controls.Add(iconPictureBox1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.Control;
            kryptonPanel1.Size = new Size(330, 420);
            kryptonPanel1.TabIndex = 0;
            // 
            // pbEye
            // 
            pbEye.Anchor = AnchorStyles.None;
            pbEye.BackColor = Color.Transparent;
            pbEye.ForeColor = SystemColors.ControlText;
            pbEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            pbEye.IconColor = SystemColors.ControlText;
            pbEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbEye.IconSize = 24;
            pbEye.Location = new Point(245, 260);
            pbEye.Name = "pbEye";
            pbEye.Size = new Size(24, 27);
            pbEye.TabIndex = 11;
            pbEye.TabStop = false;
            pbEye.Click += iconPictureBox2_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.DarkSlateBlue;
            btnIniciarSesion.BackgroundImageLayout = ImageLayout.None;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            btnIniciarSesion.IconColor = Color.Black;
            btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIniciarSesion.Location = new Point(121, 318);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(72, 33);
            btnIniciarSesion.TabIndex = 10;
            btnIniciarSesion.Text = "Iniciar";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(48, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 24);
            lblPassword.TabIndex = 9;
            lblPassword.Values.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(48, 260);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(221, 27);
            txtContraseña.TabIndex = 8;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(48, 158);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(63, 24);
            lblUser.TabIndex = 7;
            lblUser.Values.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(48, 188);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 27);
            txtUsuario.TabIndex = 6;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.BackgroundImage = Properties.Resources.ChickenFingers__1_0;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 87;
            iconPictureBox1.Location = new Point(32, 40);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(251, 87);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkSlateBlue;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(121, 375);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(72, 33);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 420);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Iniciar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox pbEye;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private Krypton.Toolkit.KryptonLabel lblPassword;
        private Krypton.Toolkit.KryptonTextBox txtContraseña;
        private Krypton.Toolkit.KryptonLabel lblUser;
        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}