using AutoMapper;
using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS.Models;
using CHICKEN_FINGERS.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVentasAPI.Services.Interfaces;

namespace CHICKEN_FINGERS.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoMetodoPagoController : ControllerBase
    {
        private readonly IService<PedidoMetodoPago> _service;
        private readonly ILogger<PedidoMetodoPagoController> _logger;
        private readonly IMapper _mapper;

        public PedidoMetodoPagoController(
            IService<PedidoMetodoPago> service,
            ILogger<PedidoMetodoPagoController> logger,
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
        public async Task<ActionResult<IEnumerable<PedidoMetodoPago>>> GetAll()
        {
            var pmp = await _service.ListarAsync();
            return Ok(_mapper.Map<IEnumerable<PedidoMetodoPago>>(pmp));
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("{idPedido:int}/{idmetodopago:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PedidoMetodoPago>> GetById(int idPedido, int idmetodopago)
        {
            if (idPedido <= 0 || idmetodopago <= 0)
                return BadRequest(new { error = "ID de pedido o metodopago no válido" });

            var pmp = await (_service as IServiceKey<PedidoMetodoPago>)!.ObtenerPorIdAsyncKey(idPedido, idmetodopago);
            if (pmp == null)
                return NotFound(new { error = "pedido metodo de pago no encontrado" });

            var pmpDto = _mapper.Map<PedidoMetodoPago>(pmp);
            return Ok(pmpDto);
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PedidoMetodoPagoDto>> Create([FromBody] PedidoMetodoPagoCreateDto createDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entidad = _mapper.Map<PedidoMetodoPago>(createDto);
            var (ok, error) = await _service.CrearAsync(entidad);

            if (!ok)
                return BadRequest(new { error });

            var pedidometodopago = _mapper.Map<PedidoMetodoPagoDto>(entidad);
            return CreatedAtAction(nameof(GetById), new { idPedido = entidad.IdPedido, idMetodoPago = entidad.IdMetodoPago}, pedidometodopago);
        }
        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpDelete("{idPedido:int}/{idMetodopago:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int idPedido, int idMetodopago)
        {
            if (idPedido <= 0 || idMetodopago <= 0)
                return BadRequest(new { error = "ID de pedido o metodopago no válido" });

            var (ok, error) = await (_service as IServiceKey<PedidoMetodoPago>)!.EliminarAsyncKey(idPedido, idMetodopago);

            if (!ok)
                return BadRequest(new { error });

            return NoContent();
        }
    }
}

