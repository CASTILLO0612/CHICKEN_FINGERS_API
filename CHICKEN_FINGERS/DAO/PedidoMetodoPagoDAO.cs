using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;
using System.Data;


namespace CHICKEN_FINGERS.DAO
{
    public class PedidoMetodoPagoDAO : RepositoryBase<PedidoMetodoPago>, IRepository<PedidoMetodoPago>, IKeyDAO<PedidoMetodoPago> 
    {
        public PedidoMetodoPagoDAO(ConexionDB conexion) : base(conexion) { }

        public override async Task<int> CreateAsync(PedidoMetodoPago pmp)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_INSERTAR_METODO_PAGO_PEDIDO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Id_Metodo_Pago", pmp.IdMetodoPago);
            cmd.Parameters.AddWithValue("@Id_Pedido", pmp.IdPedido);


            await cmd.ExecuteNonQueryAsync();
            return 1;
        }

        public async Task<bool> DeleteAsyncKey(int idPedido, int idMetodoPago)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_METODO_PAGO_PEDIDO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);
            cmd.Parameters.AddWithValue("@Id_Metodo_Pago", idMetodoPago);

            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }
        public override async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<IEnumerable<PedidoMetodoPago>> GetAllAsync()
        {

            var lista = new List<PedidoMetodoPago>();
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_LISTAR_METODOS_PAGO_PEDIDO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var pmp = new PedidoMetodoPago
                {
                    IdPedido = Convert.ToInt32(reader["Id_Pedido"]),
                    IdMetodoPago = Convert.ToInt32(reader["Id_Metodo_Pago"]),

                };
                lista.Add(pmp);
            }
            return lista;
        }

        public override Task<PedidoMetodoPago?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PedidoMetodoPago?> GetByIdAsyncKey(int idPedido, int idmetodopago)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_METODOS_PAGO_PEDIDO_POR_ID, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@id_pedido", idPedido);
            cmd.Parameters.AddWithValue("@id_metodopago", idmetodopago);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var pmp = new PedidoMetodoPago
                {
                    IdPedido = Convert.ToInt32(reader["Id_Pedido"]),
                    IdMetodoPago = Convert.ToInt32(reader["Id_Metodo_Pago"])
                };

                return pmp;
            }
            return null;
        }

        public override Task<bool> UpdateAsync(PedidoMetodoPago entity)
        {
            throw new NotImplementedException();
        }

    }
}