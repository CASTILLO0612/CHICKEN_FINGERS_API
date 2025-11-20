namespace CHICKEN_FINGERS_APP.Visuals
{
    partial class ComplementaryForm
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
            pnCliente = new Krypton.Toolkit.KryptonPanel();
            btnListo = new Krypton.Toolkit.KryptonButton();
            pbContexto = new Krypton.Toolkit.KryptonPanel();
            btnCrearCliente = new Krypton.Toolkit.KryptonButton();
            btnClienteExiste = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pnCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbContexto).BeginInit();
            pbContexto.SuspendLayout();
            SuspendLayout();
            // 
            // pnCliente
            // 
            pnCliente.Dock = DockStyle.Bottom;
            pnCliente.Location = new Point(0, 84);
            pnCliente.Name = "pnCliente";
            pnCliente.Size = new Size(443, 406);
            pnCliente.TabIndex = 0;
            // 
            // btnListo
            // 
            btnListo.Location = new Point(334, 13);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(97, 41);
            btnListo.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListo.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListo.TabIndex = 26;
            btnListo.Values.DropDownArrowColor = Color.Empty;
            btnListo.Values.Text = "Listo";
            btnListo.Click += btnListo_Click;
            // 
            // pbContexto
            // 
            pbContexto.Controls.Add(btnListo);
            pbContexto.Controls.Add(btnCrearCliente);
            pbContexto.Controls.Add(btnClienteExiste);
            pbContexto.Dock = DockStyle.Fill;
            pbContexto.Location = new Point(0, 0);
            pbContexto.Name = "pbContexto";
            pbContexto.Size = new Size(443, 84);
            pbContexto.TabIndex = 1;
            // 
            // btnCrearCliente
            // 
            btnCrearCliente.Location = new Point(173, 12);
            btnCrearCliente.Name = "btnCrearCliente";
            btnCrearCliente.Size = new Size(155, 42);
            btnCrearCliente.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearCliente.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearCliente.TabIndex = 26;
            btnCrearCliente.Values.DropDownArrowColor = Color.Empty;
            btnCrearCliente.Values.Text = "Crear cliente";
            btnCrearCliente.Click += btnAgregarCliente_Click;
            // 
            // btnClienteExiste
            // 
            btnClienteExiste.Location = new Point(12, 12);
            btnClienteExiste.Name = "btnClienteExiste";
            btnClienteExiste.Size = new Size(155, 42);
            btnClienteExiste.StateCommon.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClienteExiste.StateNormal.Content.LongText.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClienteExiste.TabIndex = 25;
            btnClienteExiste.Values.DropDownArrowColor = Color.Empty;
            btnClienteExiste.Values.Text = "Cliente existente";
            btnClienteExiste.Click += btnClienteExiste_Click;
            // 
            // ComplementaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 490);
            Controls.Add(pbContexto);
            Controls.Add(pnCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComplementaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComplementaryForm";
            ((System.ComponentModel.ISupportInitialize)pnCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbContexto).EndInit();
            pbContexto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnCliente;
        private Krypton.Toolkit.KryptonPanel pbContexto;
        private Krypton.Toolkit.KryptonButton btnCrearCliente;
        private Krypton.Toolkit.KryptonButton btnClienteExiste;
        private Krypton.Toolkit.KryptonButton btnListo;
    }
}