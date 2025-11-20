using AutoMapper;
using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CHICKEN_FINGERS.DAO
{
    public class ProductoDAO:RepositoryBase<Producto>, IRepository<Producto>
    {
        public ProductoDAO(ConexionDB conexion) : base(conexion) { }

        public override async Task<int> CreateAsync(Producto producto)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_AGREGAR_PRODUCTO, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Codigo_Producto", producto.CodigoProducto);
            cmd.Parameters.AddWithValue("@Nombre_Producto", producto.NombreProducto);
            cmd.Parameters.AddWithValue("@Precio_Unitario", producto.PrecioUnitario);
            cmd.Parameters.AddWithValue("@ID_Categoria", producto.IdCategoria);

            var result = await cmd.ExecuteScalarAsync();

            if (result != null)
            {
                producto.IdProducto = Convert.ToInt32(result);
                return producto.IdProducto;
            }

            return 0;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_PRODUCTO, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_Producto", id);

            var result = await cmd.ExecuteScalarAsync();

            return result != null && Convert.ToInt32(result) == 1;
        }

        public override async Task<IEnumerable<Producto>> GetAllAsync()
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PRODUCTOS, cn)
            { CommandType = CommandType.StoredProcedure };

            using var reader = await cmd.ExecuteReaderAsync();

            var producto = new List<Producto>();

            while (await reader.ReadAsync())
            {
                var p = new Producto
                {
                    IdProducto = Convert.ToInt32(reader["Id_Producto"]),
                    CodigoProducto = reader["Codigo_Producto"].ToString() ?? "",
                    NombreProducto = reader["Nombre_Producto"].ToString() ?? "",
                    PrecioUnitario = Convert.ToDecimal(reader["Precio_Unitario"]),
                    IdCategoria = Convert.ToInt32(reader["Id_Categoria"])
                };
                producto.Add(p);
            }
            return producto;
        }

        public override async Task<Producto?> GetByIdAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_BUSCAR_PRODUCTO_POR_ID, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_Producto", id);

            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                var producto = new Producto
                {
                    IdProducto = Convert.ToInt32(reader["Id_Producto"]),
                    CodigoProducto = reader["Codigo_Producto"].ToString() ?? "",
                    NombreProducto = reader["Nombre_Producto"].ToString() ?? "",
                    PrecioUnitario = Convert.ToDecimal(reader["Precio_Unitario"]),
                    IdCategoria = Convert.ToInt32(reader["Id_Categoria"])
                };
                return producto;
            }
            return null;
        }

        public override async Task<bool> UpdateAsync(Producto producto)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_MODIFICAR_PRODUCTO, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_Producto", producto.IdProducto);
            cmd.Parameters.AddWithValue("@Codigo_Producto", producto.CodigoProducto);
            cmd.Parameters.AddWithValue("@Nombre_Producto", producto.NombreProducto);
            cmd.Parameters.AddWithValue("@Precio_Unitario", producto.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Id_Categoria", producto.IdCategoria);

            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }
    } 
}
