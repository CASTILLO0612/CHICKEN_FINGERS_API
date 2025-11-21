using AutoMapper;
using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaPuntoController : ControllerBase
    {
        private readonly IService<TarjetaPunto> _service;
        private readonly ILogger<TarjetaPuntoController> _logger;
        private readonly IMapper _mapper;

        public TarjetaPuntoController(
            IService<TarjetaPunto> tarjetaService,
            ILogger<TarjetaPuntoController> logger,
            IMapper mapper)
        {
            _service = tarjetaService;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<IEnumerable<TarjetaPuntoDto>>> GetAll()
        {
            _logger.LogInformation("Obteniendo todas las tarjetas de puntos");
            var tarjetas = await _service.ListarAsync();
            return Ok(_mapper.Map<IEnumerable<TarjetaPuntoDto>>(tarjetas));
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TarjetaPuntoDto>> GetById(int id)
        {
            _logger.LogInformation("Obteniendo tarjeta de puntos con ID: {Id}", id);

            if (id <= 0)
                return BadRequest(new { error = "ID de tarjeta no válido" });

            var tarjeta = await _service.ObtenerPorIdAsync(id);
            if (tarjeta == null)
                return NotFound(new { error = "Tarjeta no encontrada" });

            return Ok(_mapper.Map<TarjetaPuntoDto>(tarjeta));
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<TarjetaPuntoDto>> Create([FromBody] TarjetaPuntoCreateDto createDto)
        {
            _logger.LogInformation("Creando nueva tarjeta de puntos");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entidad = _mapper.Map<TarjetaPunto>(createDto);
            var (ok, error) = await _service.CrearAsync(entidad);

            if (!ok)
                return BadRequest(new { error });

            var tarjetaDto = _mapper.Map<TarjetaPuntoDto>(entidad);
            return Ok(new { message = "Tarjeta creada exitosamente", tarjeta = tarjetaDto });
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("Eliminando tarjeta con ID: {Id}", id);

            if (id <= 0)
                return BadRequest(new { error = "ID de tarjeta no válido" });

            var existingTarjeta = await _service.ObtenerPorIdAsync(id);
            if (existingTarjeta == null)
                return NotFound(new { error = "Tarjeta no encontrada" });

            var (ok, error) = await _service.EliminarAsync(id);
            if (!ok)
                return BadRequest(new { error });

            return NoContent();
        }
    }
}
