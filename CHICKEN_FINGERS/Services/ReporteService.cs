using CHICKEN_FINGERS.DAO;
using CHICKEN_FINGERS.DAO.Interfaces;
using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class ReporteService : IReporteService
    {
        private readonly ReportesDAO _dao;

        public ReporteService(ReportesDAO reporteDAO)
        {
            _dao = reporteDAO;
        }

        public Task<IEnumerable<ReporteClienteDto>> ObtenerReporteClientes(DateTime? inicio, DateTime? fin)
        => _dao.ReporteClientesAsync(inicio, fin);
    }
}
