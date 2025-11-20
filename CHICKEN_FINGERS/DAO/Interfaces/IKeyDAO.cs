using CHICKEN_FINGERS.Models;

namespace CHICKEN_FINGERS.DAO.Interfaces
{
    public interface IKeyDAO <T> where T : class
    {
        Task<T> GetByIdAsyncKey(int idPedido, int idProducto);
        Task<bool> DeleteAsyncKey(int idPedido, int idProducto);
    }
}
