using CHICKEN_FINGERS.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHICKEN_FINGERS_APP.Models.Repository.Interfaces
{
    public interface IReporteRepository
    {
        Task<IEnumerable<ReporteClienteDto>> ObtenerReporteClientes(DateTime? inicio, DateTime? fin);
    }
}
