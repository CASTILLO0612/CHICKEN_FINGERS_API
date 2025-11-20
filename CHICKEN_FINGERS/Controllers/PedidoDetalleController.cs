using AutoMapper;
using CHICKEN_FINGERS.Models;
using CHICKEN_FINGERS.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaVentasAPI.Services.Interfaces;
using CHICKEN_FINGERS.Services.Interfaces;

namespace CHICKEN_FINGERS.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoDetalleController : ControllerBase
    {
        private readonly IService<PedidoDetalle> _service;
        private readonly ILogger<PedidoDetalleController> _logger;
        private readonly IMapper _mapper;

        public PedidoDetalleController(
            IService<PedidoDetalle> service,
            ILogger<PedidoDetalleController> logger,
            IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<IEnumerable<PedidoDetalleDto>>> GetAll()
        {
            var detalles = await _service.ListarAsync();
            return Ok(_mapper.Map<IEnumerable<PedidoDetalleDto>>(detalles));
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("{idPedido:int}/{idProducto:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PedidoDetalleDto>> GetById(int idPedido, int idProducto)
        {
            if (idPedido <= 0 || idProducto <= 0)
                return BadRequest(new { error = "ID de pedido o producto no válido" });

            var detalle = await (_service as IServiceKey<PedidoDetalle>)!.ObtenerPorIdAsyncKey(idPedido, idProducto);
            if (detalle == null)
                return NotFound(new { error = "Detalle de pedido no encontrado" });

            var detalleDto = _mapper.Map<PedidoDetalleDto>(detalle);
            return Ok(detalleDto);
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PedidoDetalleDto>> Create([FromBody] PedidoDetalleCreateDto createDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entidad = _mapper.Map<PedidoDetalle>(createDto);
            var (ok, error) = await _service.CrearAsync(entidad);

            if (!ok)
                return BadRequest(new { error });

            var detalleDto = _mapper.Map<PedidoDetalleDto>(entidad);
            return CreatedAtAction(nameof(GetById), new { idPedido = entidad.IdPedido, idProducto = entidad.IdProducto }, detalleDto);
        }
        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpDelete("{idPedido:int}/{idProducto:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int idPedido, int idProducto)
        {
            if (idPedido <= 0 || idProducto <= 0)
                return BadRequest(new { error = "ID de pedido o producto no válido" });

            var (ok, error) = await (_service as IServiceKey<PedidoDetalle>)!.EliminarAsyncKey(idPedido, idProducto);

            if (!ok)
                return BadRequest(new { error });

            return NoContent();
        }
    }
}