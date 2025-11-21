using CHICKEN_FINGERS.Dto;
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
    public partial class UC_ClienteExiste : UserControl
    {
        private readonly ApiClient _apiClient;
        public UC_ClienteExiste(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            CargarDataAsync();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComplementaryForm form = new ComplementaryForm();
            form.Close();

        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            var cliente = await _apiClient.Clientes.GetByIdAsync(Convert.ToInt32(TxtId.Text));
            dtgClientes.AutoGenerateColumns = true;
            dtgClientes.DataSource = new List<ClienteDto> { cliente };
        }

        private async Task CargarDataAsync() 
        {
            var clientes = await _apiClient.Clientes.GetAllAsync();
            dtgClientes.AutoGenerateColumns = true;
            dtgClientes.DataSource = clientes.ToList();
        }
    }
}
