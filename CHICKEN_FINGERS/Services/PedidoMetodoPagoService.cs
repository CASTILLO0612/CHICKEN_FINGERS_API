using CHICKEN_FINGERS.DAO;
using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Models;
using CHICKEN_FINGERS.Services.Interfaces;
using SistemaVentasAPI.Services;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class PedidoMetodoPagoService: ServiceBase<PedidoMetodoPago>, IService<PedidoMetodoPago>, IServiceKey<PedidoMetodoPago>
    {
        private readonly PedidoMetodoPagoDAO _dao; 

        public PedidoMetodoPagoService(IRepository<PedidoMetodoPago> repository, PedidoMetodoPagoDAO dao) : base(repository)
        {
            _dao = dao;
        }
        public override async Task<(bool ok, string error)> CrearAsync(PedidoMetodoPago pmp)
        {
            if (pmp.IdMetodoPago <= 0 || pmp.IdPedido <= 0)
                return (false, "los id no pueden ser nulos ni menores que 0 ");

            return await base.CrearAsync(pmp);
        }

        public override async Task<IEnumerable<PedidoMetodoPago>> ListarAsync() => await base.ListarAsync();
        public override async Task<PedidoMetodoPago?> ObtenerPorIdAsync(int id) => await base.ObtenerPorIdAsync(id);
        public override async Task<(bool ok, string error)> ActualizarAsync(PedidoMetodoPago c) => await base.ActualizarAsync(c);
        public override async Task<(bool ok, string error)> EliminarAsync(int id) => await base.EliminarAsync(id);
        public async Task<PedidoMetodoPago?> ObtenerPorIdAsyncKey(int idpedido, int idMetodoPago)
            => await _dao.GetByIdAsyncKey(idpedido, idMetodoPago);
        public async Task<(bool ok, string error)> EliminarAsyncKey(int idpedido, int idMetodoPago)
        {
            var ok = await _dao.DeleteAsyncKey(idpedido, idMetodoPago);
            return ok ? (true, string.Empty) : (false, "No se pudo eliminar el registro.");
        }

    }
}
