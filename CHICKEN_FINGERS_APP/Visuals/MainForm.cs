using CHICKEN_FINGERS_APP.Controllers;
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
    public partial class MainForm : Form
    {
        private readonly ApiClient _apiClient;
        public MainForm(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

            UC_Ventas vistaVentas = new UC_Ventas();
            CargarUserControl(vistaVentas);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            UC_Historial historial = new UC_Historial();
            CargarUserControl(historial);
        }


        private void CargarUserControl(UserControl userControl)
        {
            // 1. Limpiar el panel de cualquier control que estuviera visible antes
            pnPrincipal.Controls.Clear();

            // 2. Asegurar que el nuevo control llene todo el espacio del panel
            userControl.Dock = DockStyle.Fill;

            // 3. Añadir el control al panel de contenido
            pnPrincipal.Controls.Add(userControl);

            // 4. Asegurar que se muestre al frente (opcional)
            userControl.BringToFront();


        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            UC_Clientes clientes = new UC_Clientes(_apiClient);
            CargarUserControl(clientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            UC_Productos productos = new UC_Productos();
            CargarUserControl(productos);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            UC_Reportes reportes = new UC_Reportes(_apiClient);
            CargarUserControl(reportes);
        }
    }
}
