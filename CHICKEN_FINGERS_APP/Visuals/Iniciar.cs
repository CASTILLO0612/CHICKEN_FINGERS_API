using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHICKEN_FINGERS_APP.Visuals
{
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (pbEye.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                pbEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtContraseña.PasswordChar = '*';
            }
            else
            {
                txtContraseña.PasswordChar = '\0';
                pbEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
