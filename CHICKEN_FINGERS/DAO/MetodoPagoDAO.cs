using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
using System.Xml.Linq;

namespace CHICKEN_FINGERS.DAO
{
    public class MetodoPagoDAO : RepositoryBase<MetodoPago>, IRepository<MetodoPago>
    {
        public MetodoPagoDAO(ConexionDB conexion) : base(conexion) { }

        public override async Task<int> CreateAsync(MetodoPago mp)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_AGREGAR_METODO_PAGO,cn)
                { CommandType = CommandType.StoredProcedure};

            cmd.Parameters.AddWithValue("@Metodo_Pago", mp.Metodo_Pago);

            var result = await cmd.ExecuteScalarAsync();
            if (result != null)
            {
                mp.IdMetodoPago = Convert.ToInt32(result);
                return mp.IdMetodoPago;
            }

            return 0;

        }

        public override async Task<bool> DeleteAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_METODO_PAGO, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_Metodo_pago", id);

            var result = await cmd.ExecuteScalarAsync();

            return result != null && Convert.ToInt32(result) == 1;
        }

        public override async Task<IEnumerable<MetodoPago>> GetAllAsync()
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_METODOS_PAGO, cn)
            { CommandType = CommandType.StoredProcedure };

            using var reader = await cmd.ExecuteReaderAsync();

            var metodopago = new List<MetodoPago>();

            while (await reader.ReadAsync())
            {
                var p = new MetodoPago
                {
                    IdMetodoPago = Convert.ToInt32(reader["Id_Metodo_Pago"]),
                    Metodo_Pago = reader["Metodo_Pago"].ToString() ?? ""
                };
                metodopago.Add(p);
            }
            return metodopago;
        }

        public override async Task<MetodoPago?> GetByIdAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_BUSCAR_METODO_PAGO_POR_ID, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_Metodo_Pago", id);

            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                var metodopago = new MetodoPago
                {
                    IdMetodoPago = Convert.ToInt32(reader["Id_Metodo_Pago"]),
                    Metodo_Pago = reader["Metodo_Pago"].ToString() ?? ""
                };
                return metodopago;
            }
            return null;
        }

        public override async Task<bool> UpdateAsync(MetodoPago mp)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_MODIFICAR_METODO_PAGO, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_Metodo_Pago",mp.IdMetodoPago );
            cmd.Parameters.AddWithValue("@Metodo_Pago", mp.Metodo_Pago);

            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }
    }
}
