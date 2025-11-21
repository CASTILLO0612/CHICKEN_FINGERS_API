using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS_APP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHICKEN_FINGERS_APP.Visuals
{
    public partial class UC_Clientes : UserControl
    {
        private readonly ApiClient _apiClient;
        public UC_Clientes(ApiClient apiclient)
        {
            InitializeComponent();
            _apiClient = apiclient;
             LoadClientesAsync();
        }

        private async Task LoadClientesAsync()
        {
            try
            {
                var clientes = await _apiClient.Clientes.GetAllAsync();


                dtgClientes.AutoGenerateColumns = true;

                dtgClientes.DataSource = clientes.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task pnDerecho_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                var cliente = (ClienteDto)dtgClientes.Rows[e.RowIndex].DataBoundItem;
                txtPrimerNombre.Text= cliente.PNombre;
                txtSegundoNombre.Text= cliente.SNombre;
                txtPrimerApellido.Text= cliente.PApellido;
                txtSegundoApellido.Text= cliente.SApellido;
                txtDireccion.Text= cliente.Direccion;
                txtEstado.Text= cliente.Estado;
                txtTelefono.Text= cliente.Telefono;

            }
        }
        private void LimpiarCampos()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtDireccion.Clear();
            txtEstado.Clear();
            txtTelefono.Clear();
        }
    }
}
