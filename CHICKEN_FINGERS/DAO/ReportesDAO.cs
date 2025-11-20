using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Dto;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CHICKEN_FINGERS.DAO
{
    public class ReportesDAO
    {
        private readonly ConexionDB _conexion;
        public ReportesDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }
        public async Task<IEnumerable<ReporteClienteDto>> ReporteClientesAsync(DateTime? fechaInicio, DateTime? fechaFin)
        {
            var lista = new List<ReporteClienteDto>();

            using var cn = _conexion.ObtenerConexion();
            await cn.OpenAsync();

            using var cmd = new SqlCommand(Procedimientos.SP_REPORTE_CLIENTES, cn)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@FechaInicio", (object?)fechaInicio ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@FechaFin", (object?)fechaFin ?? DBNull.Value);

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                lista.Add(new ReporteClienteDto
                {
                    IdCliente = Convert.ToInt32(reader["id_cliente"]),
                    Cliente = reader["Cliente"].ToString() ?? "",
                    Direccion = reader["Direccion"].ToString() ?? "",
                    Cedula = reader["Cedula"].ToString() ?? "",
                    Estado = reader["Estado"].ToString() ?? "",
                    Telefono = reader["telefono"].ToString() ?? "",
                    CantidadPedidos = Convert.ToInt32(reader["CantidadPedidos"]),
                    TotalComprado = reader["TotalComprado"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["TotalComprado"])
                });
            }
            return lista;
        }
    }
}
