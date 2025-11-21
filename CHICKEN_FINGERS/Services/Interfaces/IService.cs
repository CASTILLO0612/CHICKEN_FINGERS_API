namespace SistemaVentasAPI.Services.Interfaces
{
    public interface IService<T> where T : class
    {
        Task<(bool ok, string error)> CrearAsync(T entity);
        Task<IEnumerable<T>> ListarAsync();
        Task<T?> ObtenerPorIdAsync(int id);
        Task<T?> ObtenerPorIdAsyncKey(int idPedido, int idProducto);
        Task<(bool ok, string error)> ActualizarAsync(T entity);
        Task<(bool ok, string error)> EliminarAsync(int id);
        Task<(bool ok, string error)> EliminarAsyncKey(int idPedido, int idProducto);
    }
}
