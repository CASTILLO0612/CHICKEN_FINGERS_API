using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Models;
using SistemaVentasAPI.Services;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class MetodoPagoService: ServiceBase<MetodoPago>, IService<MetodoPago>
    {
        public MetodoPagoService(IRepository<MetodoPago> repository) : base(repository) { }

        public override async Task<(bool ok, string error)> CrearAsync(MetodoPago mp)
        {
            // Validación 1: Campos obligatorios
            if (string.IsNullOrWhiteSpace(mp.Metodo_Pago))
                return (false, "El nombre metodo de pago es obligatorio.");

            // Llamamos al método base para insertar
            return await base.CrearAsync(mp);
        }

        public override async Task<IEnumerable<MetodoPago>> ListarAsync() => await base.ListarAsync();
        public override async Task<MetodoPago?> ObtenerPorIdAsync(int id) => await base.ObtenerPorIdAsync(id);
        public override async Task<(bool ok, string error)> ActualizarAsync(MetodoPago mp) => await base.ActualizarAsync(mp);
        public override async Task<(bool ok, string error)> EliminarAsync(int id) => await base.EliminarAsync(id);
    }
}
