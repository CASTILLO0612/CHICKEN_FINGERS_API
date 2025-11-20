using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CHICKEN_FINGERS.DAO
{
    public class PedidoDetalleDAO : RepositoryBase<PedidoDetalle>, IRepository<PedidoDetalle>, IKeyDAO <PedidoDetalle>
    {
        public PedidoDetalleDAO(ConexionDB conexion) : base(conexion) { }

        public override async Task<int> CreateAsync(PedidoDetalle entity)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_INSERTAR_PEDIDO_DETALLE, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@idpedido", entity.IdPedido);
            cmd.Parameters.AddWithValue("@idproducto", entity.IdProducto);
            cmd.Parameters.AddWithValue("@cantidad", entity.Cantidad);
            cmd.Parameters.AddWithValue("@precio_unitario", entity.PrecioUnitario);

            await cmd.ExecuteNonQueryAsync();
            return 1;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteAsyncKey(int idPedido, int idProducto)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_PEDIDO_DETALLE, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);
            cmd.Parameters.AddWithValue("@Id_Producto", idProducto);
            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }

        public override async Task<IEnumerable<PedidoDetalle>> GetAllAsync()
        {
            var lista = new List<PedidoDetalle>();
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_LISTAR_PEDIDO_DETALLE, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var p = new PedidoDetalle
                {
                    IdPedido = Convert.ToInt32(reader["Id_Pedido"]),
                    IdProducto = Convert.ToInt32(reader["Id_Producto"]),
                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                    PrecioUnitario = Convert.ToDecimal(reader["Precio_Unitario"])
                };
                lista.Add(p);
            }
            return lista;
        }

        public override async Task<PedidoDetalle?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<PedidoDetalle?> GetByIdAsyncKey(int idPedido, int idProducto)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PEDIDO_DETALLES_POR_ID, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);
            cmd.Parameters.AddWithValue("@Id_Producto", idProducto);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var p = new PedidoDetalle
                {
                    IdPedido = Convert.ToInt32(reader["Id_Pedido"]),
                    IdProducto = Convert.ToInt32(reader["Id_Producto"]),
                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                    PrecioUnitario = Convert.ToDecimal(reader["Precio_Unitario"])
                };
                return p;
            }
            return null;
        }


        public override Task<bool> UpdateAsync(PedidoDetalle entity)
        {
            throw new NotImplementedException();
        }
    }
}
