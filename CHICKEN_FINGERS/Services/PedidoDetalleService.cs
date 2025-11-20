using CHICKEN_FINGERS.DAO;
using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Models;
using CHICKEN_FINGERS.Services.Interfaces;
using SistemaVentasAPI.Services;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class PedidoDetalleService : ServiceBase<PedidoDetalle>, IService<PedidoDetalle>, IServiceKey<PedidoDetalle>
    {
        private readonly PedidoDetalleDAO _dao;
        public PedidoDetalleService(IRepository<PedidoDetalle> repository, PedidoDetalleDAO dao) : base(repository)
        {
            _dao = dao;
        }
        public override async Task<(bool ok, string error)> CrearAsync(PedidoDetalle p)
        {
            if (p.IdProducto <= 0 || p.Cantidad <= 0)
                return (false, "El producto y la cantidad deben ser especificados.");

            if (p.IdPedido == null)
                return (false, "El pedido asociado debe ser especificado.");
            return await base.CrearAsync(p);
        }

        public override async Task<IEnumerable<PedidoDetalle>> ListarAsync() => await base.ListarAsync();
        public override async Task<PedidoDetalle?> ObtenerPorIdAsync(int id) => await base.ObtenerPorIdAsync(id);
        public override async Task<(bool ok, string error)> ActualizarAsync(PedidoDetalle c) => await base.ActualizarAsync(c);
        public override async Task<(bool ok, string error)> EliminarAsync(int id) => await base.EliminarAsync(id);
        public async Task<PedidoDetalle?> ObtenerPorIdAsyncKey(int idPedido, int idProducto)
          => await _dao.GetByIdAsyncKey(idPedido, idProducto);
        public async Task<(bool ok, string error)> EliminarAsyncKey(int idPedido, int idProducto)
        {
            var ok = await _dao.DeleteAsyncKey(idPedido, idProducto);
            return ok ? (true, string.Empty) : (false, "No se pudo eliminar el registro.");
        }
    }
}
