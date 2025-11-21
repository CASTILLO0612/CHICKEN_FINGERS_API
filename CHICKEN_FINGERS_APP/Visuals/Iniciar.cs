using CHICKEN_FINGERS_APP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHICKEN_FINGERS_APP.Visuals
{
    public partial class Iniciar : Form
    {
        private readonly ApiClient _apiClient;
        public Iniciar()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        public async Task LoginAsync()
        {
            string username = txtUsuario.Text.Trim();
            string password = txtContraseña.Text.Trim();

            try
            {
                var token = await _apiClient.LoginUsers.AuthenticateUserAsync(username, password);

                if (!string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Inicio de sesión exitoso.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _apiClient.SetAuthToken(token);

                    Hide();
                    var mainform = new MainForm(_apiClient);
                    mainform.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            LoginAsync();
        }
    }
}
