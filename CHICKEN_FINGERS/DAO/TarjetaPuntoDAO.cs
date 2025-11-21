using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;

namespace CHICKEN_FINGERS.DAO
{
    public class TarjetaPuntoDAO : RepositoryBase<TarjetaPunto>, IRepository<TarjetaPunto>
    {
        public TarjetaPuntoDAO(ConexionDB context) : base(context)
        {
        }

        public override async Task<int> CreateAsync(TarjetaPunto entity)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_AGREGAR_TARJETA, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Cliente", entity.IdCliente);
            cmd.Parameters.AddWithValue("@Codigo_Tarjeta", entity.CodigoTarjeta ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Puntos_Acumulados", entity.PuntosAcumulados);
            var result = await cmd.ExecuteScalarAsync();
            if (result != null)
            {
                entity.IdTarjetaPunto = Convert.ToInt32(result);
                return entity.IdTarjetaPunto;
            }
            return 0;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_TARJETA, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Tarjeta", id);
            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }

        public override async Task<IEnumerable<TarjetaPunto>> GetAllAsync()
        {
            var lista = new List<TarjetaPunto>();

            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_LISTAR_TARJETAS, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            using var reader = await cmd.ExecuteReaderAsync();
            while (reader.Read())
            {
                var t = new TarjetaPunto
                {
                    IdTarjetaPunto = Convert.ToInt32(reader["Id_Tarjeta"]),
                    IdCliente = Convert.ToInt32(reader["Id_Cliente"]),
                    CodigoTarjeta = reader["Codigo_Tarjeta"] == DBNull.Value ? null : reader["Codigo_Tarjeta"].ToString(),
                    PuntosAcumulados = Convert.ToDecimal(reader["Puntos_Acumulados"])

                };
                lista.Add(t);

            }
            return lista;
        }

        public override async Task<TarjetaPunto?> GetByIdAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_TARJETAS_POR_ID, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Tarjeta", id);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var cliente =  new TarjetaPunto
                {
                    IdTarjetaPunto = Convert.ToInt32(reader["Id_Tarjeta"]),
                    IdCliente = Convert.ToInt32(reader["Id_Cliente"]),
                    CodigoTarjeta = reader["Codigo_Tarjeta"] == DBNull.Value ? null : reader["Codigo_Tarjeta"].ToString(),
                    PuntosAcumulados = Convert.ToDecimal(reader["Puntos_Acumulados"])
                };
                return cliente;
            }
            return null;
        }

        public override Task<bool> UpdateAsync(TarjetaPunto entity)
        {
            throw new NotImplementedException();
        }
    }
}
