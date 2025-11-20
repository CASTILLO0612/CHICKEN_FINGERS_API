using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Models;
using SistemaVentasAPI.Services;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class PedidoService : ServiceBase<Pedido>, IService<Pedido>
    {
        public PedidoService(IRepository<Pedido> repository) : base(repository) { }

        public override async Task<(bool ok, string error)> CrearAsync(Pedido p)
        {
            // Validación 1: Campos obligatorios
            if (string.IsNullOrWhiteSpace(p.IdCliente.ToString()))
                return (false, "El ID Cliente es obligatorios.");

            // Llamamos al método base para insertar
            return await base.CrearAsync(p);
        }

        public override async Task<IEnumerable<Pedido>> ListarAsync() => await base.ListarAsync();
        public override async Task<Pedido?> ObtenerPorIdAsync(int id) => await base.ObtenerPorIdAsync(id);
        public override async Task<(bool ok, string error)> ActualizarAsync(Pedido p) => await base.ActualizarAsync(p);
        public override async Task<(bool ok, string error)> EliminarAsync(int id) => await base.EliminarAsync(id);

    }
}
