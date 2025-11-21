using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Models;
using SistemaVentasAPI.Services;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class CategoriaService : ServiceBase<Categoria>, IService<Categoria>
    {
        public CategoriaService(IRepository<Categoria> repository) : base(repository)
        {
        }
        public override async Task<(bool ok, string error)> CrearAsync(Categoria c)
        {
            if (string.IsNullOrWhiteSpace(c.NombreCategoria))
                return (false, "El nombre de la categoría es obligatorio.");
            return await base.CrearAsync(c);
        }
        public override async Task<IEnumerable<Categoria>> ListarAsync() => await base.ListarAsync();
        public override async Task<Categoria?> ObtenerPorIdAsync(int id) => await base.ObtenerPorIdAsync(id);
        public override async Task<(bool ok, string error)> ActualizarAsync(Categoria c)
        {
            if (string.IsNullOrWhiteSpace(c.NombreCategoria))
                return (false, "El nombre de la categoría es obligatorio.");

            return await base.ActualizarAsync(c);
        }
        public override async Task<(bool ok, string error)> EliminarAsync(int id) => await base.EliminarAsync(id);
    }
}
