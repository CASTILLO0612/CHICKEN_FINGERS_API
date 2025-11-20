namespace CHICKEN_FINGERS.Services.Interfaces
{
    public interface IServiceKey<T> where T : class
    {
        Task<T?> ObtenerPorIdAsyncKey(int id1, int id2);
        Task<(bool ok, string error)> EliminarAsyncKey(int id1, int id2);
    }
}
