using AutoMapper;
using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CHICKEN_FINGERS.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportesController : ControllerBase
    {
        private readonly IReporteService _service;
        private readonly ILogger<ReportesController> _logger;
        private readonly IMapper _mapper;

        public ReportesController(IReporteService service, ILogger<ReportesController> logger,
            IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("ClientesJson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ReporteClienteDto>>> ClientesJson(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            _logger.LogInformation("Obteniendo reporte de los clientes");

            var data = await _service.ObtenerReporteClientes(fechaInicio, fechaFin);
            return Ok(_mapper.Map<IEnumerable<ReporteClienteDto>>(data));
        }
    }
}
