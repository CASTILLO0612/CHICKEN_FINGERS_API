using CHICKEN_FINGERS.Dto;

namespace CHICKEN_FINGERS.Services.Interfaces
{
    public interface IReporteService
    {
        Task<IEnumerable<ReporteClienteDto>> ObtenerReporteClientes(DateTime? inicio, DateTime? fin);
    }
}
