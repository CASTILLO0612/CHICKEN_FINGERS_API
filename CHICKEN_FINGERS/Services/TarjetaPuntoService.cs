using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Models;
using SistemaVentasAPI.Services;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class TarjetaPuntoService : ServiceBase<TarjetaPunto>, IService<TarjetaPunto>
    {
        public TarjetaPuntoService(IRepository<TarjetaPunto> repository) : base(repository)
        {
        }
        public override async Task<(bool ok, string error)> CrearAsync(TarjetaPunto t)
        {
            if (t.IdCliente <= 0)
                return (false, "Debe especificarse un cliente válido.");

            if (string.IsNullOrWhiteSpace(t.CodigoTarjeta))
                return (false, "El código de la tarjeta no puede estar vacío.");

                t.PuntosAcumulados = 0;

            return await base.CrearAsync(t);
        }

        public override async Task<IEnumerable<TarjetaPunto>> ListarAsync() => await base.ListarAsync();
        public override async Task<TarjetaPunto?> ObtenerPorIdAsync(int id) => await base.ObtenerPorIdAsync(id);
        public override async Task<(bool ok, string error)> ActualizarAsync(TarjetaPunto t) => await base.ActualizarAsync(t);
        public override async Task<(bool ok, string error)> EliminarAsync(int id) => await base.EliminarAsync(id);
    }
}
