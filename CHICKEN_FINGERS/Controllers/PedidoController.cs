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
    public class PedidoController : ControllerBase
    {
        private readonly IService<Pedido> _pedidoservice;
        private readonly ILogger<PedidoController> _logger;
        private readonly IMapper _mapper;

        public PedidoController(
            IService<Pedido> pedidoservice,
            ILogger<PedidoController> logger,
            IMapper mapper)
        {
            _pedidoservice = pedidoservice;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PedidoDto>>> GetAll()
        {
            _logger.LogInformation("Obteniendo todos los pedidos");

            var pedido = await _pedidoservice.ListarAsync();
            return Ok(_mapper.Map<IEnumerable<PedidoDto>>(pedido));
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PedidoDto>> GetById(int id)
        {
            if (id <= 0)
            {
                _logger.LogWarning("ID de pedido no válido: {Id}", id);
                return BadRequest(new { error = "ID de pedido no válido" });
            }

            _logger.LogInformation("Obteniendo pedido con ID: {Id}", id);

            var pedido = await _pedidoservice.ObtenerPorIdAsync(id);
            if (pedido == null)
            {
                _logger.LogWarning("pedido con ID {Id} no encontrado", id);
                return NotFound(new { error = "pedido no encontrado" });
            }

            return Ok(_mapper.Map<PedidoDto>(pedido));
        }

        [Authorize(Roles = "Gerente")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PedidoDto>> Create([FromBody] PedidoCreateDto createDto)
        {
            _logger.LogInformation("Creando nuevo pedido");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al crear pedido");
                return BadRequest(ModelState);
            }

            var pedido = _mapper.Map<Pedido>(createDto);
            var (ok, error) = await _pedidoservice.CrearAsync(pedido);

            if (!ok)
            {
                _logger.LogWarning("Error al crear pedido: {Error}", error);
                return BadRequest(new { error });
            }

            var pedidoDto = _mapper.Map<PedidoDto>(pedido);

            _logger.LogInformation("Pedido creado exitosamente con ID: {Id}", pedido.IdPedido);

            return CreatedAtAction(
                nameof(GetById),
                new { id = pedido.IdPedido },
                new { message = "pedido creado exitosamente", pedido = pedidoDto });
        }

        [Authorize(Roles = "Gerente")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("Eliminando pedido con ID: {Id}", id);

            if (id <= 0)
            {
                _logger.LogWarning("ID de pedido no válido: {Id}", id);
                return BadRequest(new { error = "ID de pedido no válido" });
            }

            var existingPedido = await _pedidoservice.ObtenerPorIdAsync(id);
            if (existingPedido == null)
            {
                _logger.LogWarning("Pedido con ID {Id} no encontrado para eliminar", id);
                return NotFound(new { error = "pedido no encontrado" });
            }

            var (ok, error) = await _pedidoservice.EliminarAsync(id);

            if (!ok)
            {
                _logger.LogWarning("Error al eliminar pedido: {Error}", error);
                return BadRequest(new { error });
            }

            _logger.LogInformation("Pedido con ID {Id} eliminado exitosamente", id);

            return NoContent();
        }
    }
}
