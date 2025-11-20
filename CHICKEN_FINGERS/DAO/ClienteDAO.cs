using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CHICKEN_FINGERS.DAO
{
    public class ClienteDAO : RepositoryBase<Cliente>, IRepository<Cliente>
    {
        public ClienteDAO(ConexionDB conexion) : base(conexion) { }

        public override async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var lista = new List<Cliente>();

            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_CLIENTES, cn)
            { CommandType = CommandType.StoredProcedure };

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var c = new Cliente
                {
                    IdCliente = Convert.ToInt32(reader["Id_cliente"]),
                    PNombre = reader["Primer_Nombre"].ToString() ?? "",
                    SNombre = reader["Segundo_Nombre"].ToString() ?? "",
                    PApellido = reader["Primer_Apellido"].ToString() ?? "",
                    SApellido = reader["Segundo_Apellido"].ToString() ?? "",
                    Direccion = reader["Direccion"] == DBNull.Value ? null : reader["Direccion"].ToString(),
                    Telefono = reader["Telefono"] == DBNull.Value ? null : reader["telefono"].ToString(),
                    Cedula = reader["Cedula"].ToString() ?? "",
                    Estado = reader["Estado"].ToString() ?? ""
                };
                if (reader.GetSchemaTable()?.Columns.Contains("Fecha_Registro") == true && reader["Fecha_Registro"] != DBNull.Value)
                    c.Fecha_Registro = Convert.ToDateTime(reader["Fecha_Registro"]);
                lista.Add(c);
            }

            return lista;
        }

        public override async Task<Cliente?> GetByIdAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_BUSCAR_CLIENTE_POR_ID, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_cliente", id);

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(reader["Id_cliente"]),
                    PNombre = reader["Primer_Nombre"].ToString() ?? "",
                    SNombre = reader["Segundo_Nombre"] == DBNull.Value ? null : reader["Segundo_Nombre"].ToString(),
                    PApellido = reader["Primer_Apellido"].ToString() ?? "",
                    SApellido = reader["Segundo_Apellido"] == DBNull.Value ? null : reader["Segundo_Apellido"].ToString(),
                    Direccion = reader["Direccion"] == DBNull.Value ? null : reader["Direccion"].ToString(),
                    Telefono = reader["Telefono"] == DBNull.Value ? null : reader["Telefono"].ToString(),
                    Cedula = reader["Cedula"].ToString() ?? "",
                    Estado = reader["Estado"].ToString() ?? ""
                };

                if (reader.GetSchemaTable()?.Columns.Contains("Fecha_Registro") == true && reader["Fecha_Registro"] != DBNull.Value)
                    cliente.Fecha_Registro = Convert.ToDateTime(reader["Fecha_Registro"]);

                return cliente;
            }

            return null; // Cliente no encontrado
        }

        public override async Task<int> CreateAsync(Cliente c)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_AGREGAR_CLIENTE, cn)
            { CommandType = CommandType.StoredProcedure };


            cmd.Parameters.AddWithValue("@Primer_Nombre", c.PNombre);
            cmd.Parameters.AddWithValue("@Segundo_Nombre", (object?)c.SNombre ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Primer_Apellido", c.PApellido);
            cmd.Parameters.AddWithValue("@Segundo_Apellido", (object?)c.SApellido ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Direccion", (object?)c.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object?)c.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cedula", c.Cedula);

            // Si tu stored procedure devuelve el ID nuevo, usa ExecuteScalarAsync
            var result = await cmd.ExecuteScalarAsync();

            // Asignar el ID a la entidad Cliente
            if (result != null)
            {
                c.IdCliente = Convert.ToInt32(result);
                return c.IdCliente;
            }

            return 0;
        }

        public override async Task<bool> UpdateAsync(Cliente c)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_MODIFICAR_CLIENTE, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@Id_cliente", c.IdCliente);
            cmd.Parameters.AddWithValue("@Primer_nombre", c.PNombre);
            cmd.Parameters.AddWithValue("@Segund_nombre", (object?)c.SNombre ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Primer_apellido", c.PApellido);
            cmd.Parameters.AddWithValue("@Segundo_apellido", (object?)c.SApellido ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@direccion", (object?)c.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@telefono", (object?)c.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@cedula", c.Cedula);

            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_CLIENTE, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@id_cliente", id);

            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }
    }
}

