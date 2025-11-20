using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CHICKEN_FINGERS.DAO
{
    public class PedidoDAO:RepositoryBase<Pedido>, IRepository<Pedido>
    {
        public PedidoDAO(ConexionDB conexion) : base(conexion) { }

        public override async Task<int> CreateAsync(Pedido p)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_INSERTAR_PEDIDO, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@id_cliente", p.IdCliente);
            cmd.Parameters.AddWithValue("@fecha_venta", p.FechaVenta);
            
            var result = await cmd.ExecuteScalarAsync();

            if (result != null)
            {
                p.IdPedido = Convert.ToInt32(result);
                return p.IdPedido;
            }

            return 0;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_PEDIDOS, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@id_pedido", id);

            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }

        public override async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            var lista = new List<Pedido>();

            using var cn = await GetOpenConnectionAsync();
           using var cmd = new SqlCommand(Procedimientos.SP_LISTAR_PEDIDOS, cn)
           { CommandType = CommandType.StoredProcedure };

            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var p = new Pedido
                {
                    IdPedido = Convert.ToInt32(reader["Id_Pedido"]),
                    IdCliente = Convert.ToInt32(reader["Id_Cliente"]),
                };
                if (reader.GetSchemaTable()?.Columns.Contains("Fecha_Venta") == true && reader["Fecha_Venta"] != DBNull.Value)
                    p.FechaVenta = Convert.ToDateTime(reader["Fecha_Venta"]);
                lista.Add(p);
            }

            return lista;
        }

        public override async Task<Pedido?> GetByIdAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PEDIDOS_POR_ID, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@id_pedido", id);

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var pedido = new Pedido
                {
                    IdPedido = Convert.ToInt32(reader["Id_Pedido"]),
                    IdCliente = Convert.ToInt32(reader["Id_Cliente"]),
                };

                if (reader.GetSchemaTable()?.Columns.Contains("Fecha_Venta") == true && reader["Fecha_Venta"] != DBNull.Value)
                    pedido.FechaVenta = Convert.ToDateTime(reader["Fecha_Venta"]);

                return pedido;
            }

            return null; 
        }

        public override Task<bool> UpdateAsync(Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
