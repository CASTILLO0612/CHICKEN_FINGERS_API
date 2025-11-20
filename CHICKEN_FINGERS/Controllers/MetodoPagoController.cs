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
    public class MetodoPagoController : ControllerBase
    {
        private readonly IService<MetodoPago> _metodopagoservice;
        private readonly ILogger<MetodoPagoController> _logger;
        private readonly IMapper _mapper;

        public MetodoPagoController(
            IService<MetodoPago> metodopagoservice,
            ILogger<MetodoPagoController> logger,
            IMapper mapper)
        {
            _metodopagoservice = metodopagoservice;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MetodoPagoDto>>> GetAll()
        {
            _logger.LogInformation("Obteniendo todos los metodopagos");

            var metodopagos = await _metodopagoservice.ListarAsync();
            return Ok(_mapper.Map<IEnumerable<MetodoPagoDto>>(metodopagos));
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MetodoPagoDto>> GetById(int id)
        {
            if (id <= 0)
            {
                _logger.LogWarning("ID de metodopago no válido: {Id}", id);
                return BadRequest(new { error = "ID de metodopago no válido" });
            }

            _logger.LogInformation("Obteniendo metodopago con ID: {Id}", id);

            var metodopago = await _metodopagoservice.ObtenerPorIdAsync(id);
            if (metodopago == null)
            {
                _logger.LogWarning("metodopago con ID {Id} no encontrado", id);
                return NotFound(new { error = "metodopago no encontrado" });
            }

            return Ok(_mapper.Map<MetodoPagoDto>(metodopago));
        }

        [Authorize(Roles = "Gerente")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MetodoPagoDto>> Create([FromBody] MetodoPagoCreateDto createDto)
        {
            _logger.LogInformation("Creando nuevo metodopago");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al crear metodopago");
                return BadRequest(ModelState);
            }

            var metodospago = _mapper.Map<MetodoPago>(createDto);
            var (ok, error) = await _metodopagoservice.CrearAsync(metodospago);

            if (!ok)
            {
                _logger.LogWarning("Error al crear metodopago: {Error}", error);
                return BadRequest(new { error });
            }

            var metodospagoDto = _mapper.Map<MetodoPagoDto>(metodospago);

            _logger.LogInformation("metodopago creado exitosamente con ID: {Id}", metodospago.Metodo_Pago);

            return CreatedAtAction(
                nameof(GetById),
                new { id = metodospago.IdMetodoPago },
                new { message = "metodopago creado exitosamente", metodopago = metodospagoDto });
        }

        [Authorize(Roles = "Gerente")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MetodoPagoDto>> Update(int id, [FromBody] MetodoPagoUpdateDto updateDto)
        {
            _logger.LogInformation("Actualizando metodopago con ID: {Id}", id);

            if (id != updateDto.IdMetodoPago)
            {
                _logger.LogWarning("ID de ruta {Id} no coincide con ID del cuerpo {BodyId}",
                    id, updateDto.IdMetodoPago);
                return BadRequest(new { error = "El ID del metodopago no coincide" });
            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al actualizar metodopago");
                return BadRequest(ModelState);
            }

            var existingmetodopago = await _metodopagoservice.ObtenerPorIdAsync(id);
            if (existingmetodopago == null)
            {
                _logger.LogWarning("metodopago con ID {Id} no encontrado para actualizar", id);
                return NotFound(new { error = "metodopago no encontrado" });
            }

            _mapper.Map(updateDto, existingmetodopago);
            var (ok, error) = await _metodopagoservice.ActualizarAsync(existingmetodopago);

            if (!ok)
            {
                _logger.LogWarning("Error al actualizar metodopago: {Error}", error);
                return BadRequest(new { error });
            }

            var metodopagoDto = _mapper.Map<MetodoPagoDto>(existingmetodopago);

            _logger.LogInformation("metodopago con ID {Id} actualizado exitosamente", id);

            return Ok(new { message = "metodopago actualizado exitosamente", metodopago = metodopagoDto });
        }

        [Authorize(Roles = "Gerente")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("Eliminando metodopago con ID: {Id}", id);

            if (id <= 0)
            {
                _logger.LogWarning("ID de metodopago no válido: {Id}", id);
                return BadRequest(new { error = "ID de metodopago no válido" });
            }

            var existingmetodopago = await _metodopagoservice.ObtenerPorIdAsync(id);
            if (existingmetodopago == null)
            {
                _logger.LogWarning("metodopago con ID {Id} no encontrado para eliminar", id);
                return NotFound(new { error = "metodopago no encontrado" });
            }

            var (ok, error) = await _metodopagoservice.EliminarAsync(id);

            if (!ok)
            {
                _logger.LogWarning("Error al eliminar metodopago: {Error}", error);
                return BadRequest(new { error });
            }

            _logger.LogInformation("metodopago con ID {Id} eliminado exitosamente", id);

            return NoContent();
        }
    }
}
