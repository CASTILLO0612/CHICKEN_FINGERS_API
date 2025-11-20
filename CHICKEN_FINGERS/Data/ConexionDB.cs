using Microsoft.Data.SqlClient;

namespace CHICKEN_FINGERS.Data
{
    public class ConexionDB
    {
        private readonly string _cadenaSQL;
        public ConexionDB(IConfiguration config)
        {
            _cadenaSQL = config.GetConnectionString("CadenaSQL")!;
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaSQL);
        }
    }
}
