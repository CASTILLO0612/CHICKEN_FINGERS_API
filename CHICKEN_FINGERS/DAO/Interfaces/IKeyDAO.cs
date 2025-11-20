using CHICKEN_FINGERS.Models;

namespace CHICKEN_FINGERS.DAO.Interfaces
{
    public interface IKeyDAO
    {
        Task<PedidoDetalle?> GetByIdAsyncKey(int idPedido, int idProducto);
        Task<bool> DeleteAsyncKey(int idPedido, int idProducto);
    }
}
