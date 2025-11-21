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
    public partial class UC_Productos : UserControl
    {
        private readonly ApiClient _apiClient;

        public UC_Productos(ApiClient apiClient)
        {
            InitializeComponent();

            _apiClient = apiClient;
            LoadProductsAsync();
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                var products = await _apiClient.Productos.GetAllAsync();
                dtgProductos.AutoGenerateColumns = true;
                dtgProductos.DataSource = products.ToList();
                //CATEGORIAS
                var categories = await _apiClient.Categoria.GetAllAsync();
                dtgCategorias.AutoGenerateColumns = true;
                dtgCategorias.DataSource = categories.ToList();
                cbCategoria.Items.Clear();
                foreach (var category in categories)
                {
                    cbCategoria.Items.Add(category.NombreCategoria);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var producto = (ProductoDto)dtgProductos.Rows[e.RowIndex].DataBoundItem;
            txtIdProducto.Text = producto.IdProducto.ToString();
            txtNombreProducto.Text = producto.NombreProducto;
            txtCodigoProducto.Text = producto.CodigoProducto;
            txtPrecioUnitario.Text = producto.PrecioUnitario.ToString();
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtCodigoProducto.Clear();
            txtPrecioUnitario.Clear();
            txtNombreCategoria.Clear();
            txtIdCategoria.Clear();
        }
        //botones para productos
        private async void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dtgProductos.SelectedRows.Count > 0)
            {
                var productoSelected = (ProductoDto)dtgProductos.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar el producto {productoSelected.NombreProducto}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var sucess =
                            await _apiClient.Productos.DeleteAsync(productoSelected.IdProducto);
                        if (sucess)
                        {
                            MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            await LoadProductsAsync();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dtgProductos.SelectedRows.Count > 0)
            {
                var productoSelected = (ProductoDto)dtgProductos.SelectedRows[0].DataBoundItem;
                var categorias = await _apiClient.Categoria.GetAllAsync();
                var categoriaSelected = cbCategoria.SelectedItem.ToString();
                var categoriaID = categorias
                     .FirstOrDefault(c => c.NombreCategoria == categoriaSelected)?.IdCategoria;
                //  cbCategoria.Text = productoSelected.IdCategoria.ToString();

                var updateProducto = new ProductoUpdateDto
                {
                    IdProducto = productoSelected.IdProducto,
                    NombreProducto = txtNombreProducto.Text,
                    IdCategoria = categoriaID.Value,
                    CodigoProducto = txtCodigoProducto.Text,
                    PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text)

                };
                try
                {
                    var success
                        = await _apiClient.Productos.UpdateAsync(productoSelected.IdProducto, updateProducto);
                    if (success)
                    {
                        MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        await LoadProductsAsync();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var categorias =
                    await _apiClient.Categoria.GetAllAsync();
                var categoriaSelected = cbCategoria.SelectedItem.ToString();
                var categoriaID = categorias
                     .FirstOrDefault(c => c.NombreCategoria == categoriaSelected)?.IdCategoria;
                if (categoriaID == null)
                {
                    MessageBox.Show("Categoría no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var newProducto = new ProductoCreateDto
                    {
                        NombreProducto = txtNombreProducto.Text,
                        IdCategoria = categoriaID.Value,
                        CodigoProducto = txtCodigoProducto.Text,
                        PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text)
                    };

                    var success = await _apiClient.Productos.CreateAsync(newProducto);
                    if (success != null)
                    {
                        MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        await LoadProductsAsync();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        //botones para categorias
        private async void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dtgCategorias.SelectedRows.Count > 0)
            {
                var selectedCategoria = (CategoriaDto)dtgCategorias.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar la categoría {selectedCategoria.NombreCategoria}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var success =
                            await _apiClient.Categoria.DeleteAsync(selectedCategoria.IdCategoria);
                        if (success)
                        {
                            MessageBox.Show("Categoría eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            await LoadProductsAsync();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la categoría, primero se deben eliminar los productos asociados a la categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dtgCategorias.SelectedRows.Count > 0)
            {
                var selectedCategoria = (CategoriaDto)dtgCategorias.SelectedRows[0].DataBoundItem;
                var categoriaUpdate = new CategoriaDto
                {
                    IdCategoria = selectedCategoria.IdCategoria,
                    NombreCategoria = txtNombreCategoria.Text
                };
                try
                {
                    var success =
                        await _apiClient.Categoria.UpdateAsync(selectedCategoria.IdCategoria, categoriaUpdate);
                    if (success)
                    {
                        MessageBox.Show("Categoría actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        await LoadProductsAsync();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var categoria = (CategoriaDto)dtgCategorias.Rows[e.RowIndex].DataBoundItem;
            txtIdCategoria.Text = categoria.IdCategoria.ToString();
            txtNombreCategoria.Text = categoria.NombreCategoria;

        }

        private async void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            var newCategoria = new CategoriaDto
            {
                NombreCategoria = txtNombreCategoria.Text
            };
            try
            {
                var success =  await _apiClient.Categoria.CreateAsync(newCategoria);
                MessageBox.Show("Categoría agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
