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
            if (e.RowIndex >= 0)
            {
                var cliente = (ClienteDto)dtgClientes.Rows[e.RowIndex].DataBoundItem;
                txtPrimerNombre.Text = cliente.PNombre;
                txtSegundoNombre.Text = cliente.SNombre;
                txtPrimerApellido.Text = cliente.PApellido;
                txtSegundoApellido.Text = cliente.SApellido;
                txtDireccion.Text = cliente.Direccion;
                txtEstado.Text = cliente.Estado;
                txtTelefono.Text = cliente.Telefono;
                txtCedula.Text = cliente.Cedula;
                txtId.Text = cliente.IdCliente.ToString();

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

        private async void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var newCliente = new ClienteCreateDto
            {
                PNombre = txtPrimerNombre.Text,
                SNombre = txtSegundoNombre.Text,
                PApellido = txtPrimerApellido.Text,
                SApellido = txtSegundoApellido.Text,
                Direccion = txtDireccion.Text,
                Estado = txtEstado.Text,
                Telefono = txtTelefono.Text,
                Cedula = txtCedula.Text,
            };

            try
            {
                var success = await _apiClient.Clientes.CreateAsync(newCliente);
                MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                await LoadClientesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                var selectedCliente = (ClienteDto)dtgClientes.SelectedRows[0].DataBoundItem;
                var updatedCliente = new ClienteUpdateDto
                {
                    IdCliente = selectedCliente.IdCliente,
                    PNombre = txtPrimerNombre.Text,
                    SNombre = txtSegundoNombre.Text,
                    PApellido = txtPrimerApellido.Text,
                    SApellido = txtSegundoApellido.Text,
                    Direccion = txtDireccion.Text,
                    Estado = txtEstado.Text,
                    Telefono = txtTelefono.Text,
                    Cedula = txtCedula.Text,

                };
                try
                {
                    var success = await _apiClient.Clientes.UpdateAsync(selectedCliente.IdCliente, updatedCliente);
                    MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadClientesAsync();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                var selectedCliente = (ClienteDto)dtgClientes.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar al cliente " +
                    $"{selectedCliente.PNombre} {selectedCliente.PApellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    try
                    {
                        var success = await _apiClient.Clientes.DeleteAsync(selectedCliente.IdCliente);
                        if (success)
                        {
                            MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            await LoadClientesAsync();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                {
                    MessageBox.Show("Seleccione un cliente a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

