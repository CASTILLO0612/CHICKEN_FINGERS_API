using CHICKEN_FINGERS_APP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHICKEN_FINGERS_APP.Visuals
{
    public partial class ComplementaryForm : Form
    {
         ApiClient _apiClient;
        public ComplementaryForm()
        {
            InitializeComponent();

        }


        private void CargarUserControl(UserControl userControl)
        {
            // 1. Limpiar el panel de cualquier control que estuviera visible antes
            pnCliente.Controls.Clear();

            // 2. Asegurar que el nuevo control llene todo el espacio del panel
            userControl.Dock = DockStyle.Fill;

            // 3. Añadir el control al panel de contenido
            pnCliente.Controls.Add(userControl);

            // 4. Asegurar que se muestre al frente (opcional)
            userControl.BringToFront();


        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            UC_AgregarCliente agregarCliente = new UC_AgregarCliente();
            CargarUserControl(agregarCliente);
        }

        private void btnClienteExiste_Click(object sender, EventArgs e)
        {
            UC_ClienteExiste clienteExiste = new UC_ClienteExiste(_apiClient);
            CargarUserControl(clienteExiste);
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}
