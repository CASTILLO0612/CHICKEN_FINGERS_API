using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Data;
using CHICKEN_FINGERS.Models;
using Microsoft.Data.SqlClient;

namespace CHICKEN_FINGERS.DAO
{
    public class CategoriaDAO : RepositoryBase<Categoria>, IRepository<Categoria>
    {
        public CategoriaDAO(ConexionDB conexion) : base(conexion)
        {
        }

        public override async Task<int> CreateAsync(Categoria entity)
        {
            var lista = new List<Categoria>();

            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_INSERTAR_CATEGORIA, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            
            cmd.Parameters.AddWithValue("@Nombre_Categoria", entity.NombreCategoria);
             var result = await cmd.ExecuteScalarAsync();
            entity.IdCategoria = result != null ? Convert.ToInt32(result) : 0;
            return entity.IdCategoria;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_CATEGORIA, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Categoria", id);
            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }

        public async override Task<IEnumerable<Categoria>> GetAllAsync()
        {
            var lista= new List<Categoria>();
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_TODAS_CATEGORIAS, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            using var reader = cmd.ExecuteReaderAsync();
            while (await reader.Result.ReadAsync())
            {
                var c = new Categoria
                {
                    IdCategoria = Convert.ToInt32(reader.Result["Id_Categoria"]),
                    NombreCategoria = reader.Result["Nombre_Categoria"].ToString()!
                };
                lista.Add(c);
            }
            return lista;
        }

        public override async Task<Categoria?> GetByIdAsync(int id)
        {
            using var cn = await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_CATEGORIA_POR_ID, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Categoria", id);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var c = new Categoria
                {
                    IdCategoria = Convert.ToInt32(reader["Id_Categoria"]),
                    NombreCategoria = reader["Nombre_Categoria"].ToString()!
                };
                return c;
            }
            return null;
        }

        public override async Task<bool> UpdateAsync(Categoria entity)
        {
            using var cn =  await GetOpenConnectionAsync();
            using var cmd = new SqlCommand(Procedimientos.SP_ACTUALIZAR_CATEGORIA, cn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id_Categoria", entity.IdCategoria);
            cmd.Parameters.AddWithValue("@Nombre_Categoria", entity.NombreCategoria);
            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToInt32(result) == 1;
        }
    }
}
