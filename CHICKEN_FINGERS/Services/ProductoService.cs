using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Models;
using SistemaVentasAPI.Services;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class ProductoService: ServiceBase<Producto>, IService<Producto>
    {
        public ProductoService(IRepository<Producto> repository) : base(repository) { }

        public override async Task<(bool ok, string error)> CrearAsync(Producto p)
        {
            // Validación 1: Campos obligatorios
            if(p.PrecioUnitario <= 0)
                return (false, "El precio unitario debe ser mayor que cero.");

            if (string.IsNullOrEmpty(p.CodigoProducto)) 
                return (false, "El código de producto es obligatorio.");

            // Llamamos al método base para insertar
            return await base.CrearAsync(p);
        }

        public override async Task<IEnumerable<Producto>> ListarAsync() => await base.ListarAsync();
        public override async Task<Producto?> ObtenerPorIdAsync(int id) => await base.ObtenerPorIdAsync(id);
        public override async Task<(bool ok, string error)> ActualizarAsync(Producto c) => await base.ActualizarAsync(c);
        public override async Task<(bool ok, string error)> EliminarAsync(int id) => await base.EliminarAsync(id);
    }
}
