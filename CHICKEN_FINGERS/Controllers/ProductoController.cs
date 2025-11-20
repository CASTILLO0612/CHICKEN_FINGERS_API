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
    public class ProductoController : ControllerBase
    {
        private readonly IService<Producto> _productoservice;
        private readonly ILogger<ProductoController> _logger;
        private readonly IMapper _mapper;

        public ProductoController(
            IService<Producto> productoservice,
            ILogger<ProductoController> logger,
            IMapper mapper)
        {
            _productoservice = productoservice;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetAll()
        {
            _logger.LogInformation("Obteniendo todos los productos");

            var productos = await _productoservice.ListarAsync();
            return Ok(_mapper.Map<IEnumerable<ProductoDto>>(productos));
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductoDto>> GetById(int id)
        {
            if (id <= 0)
            {
                _logger.LogWarning("ID de producto no válido: {Id}", id);
                return BadRequest(new { error = "ID de producto no válido" });
            }

            _logger.LogInformation("Obteniendo producto con ID: {Id}", id);

            var producto = await _productoservice.ObtenerPorIdAsync(id);
            if (producto == null)
            {
                _logger.LogWarning("producto con ID {Id} no encontrado", id);
                return NotFound(new { error = "Producto no encontrado" });
            }

            return Ok(_mapper.Map<ProductoDto>(producto));
        }

        [Authorize(Roles = "Gerente")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProductoDto>> Create([FromBody] ProductoCreateDto createDto)
        {
            _logger.LogInformation("Creando nuevo producto");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al crear producto");
                return BadRequest(ModelState);
            }

            var producto = _mapper.Map<Producto>(createDto);
            var (ok, error) = await _productoservice.CrearAsync(producto);

            if (!ok)
            {
                _logger.LogWarning("Error al crear producto: {Error}", error);
                return BadRequest(new { error });
            }

            var productoDto = _mapper.Map<ProductoDto>(producto);

            _logger.LogInformation("Producto creado exitosamente con ID: {Id}", producto.IdProducto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = producto.IdProducto },
                new { message = "Producto creado exitosamente", producto = productoDto });
        }

        [Authorize(Roles = "Gerente")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProductoDto>> Update(int id, [FromBody] ProductoUpdateDto updateDto)
        {
            _logger.LogInformation("Actualizando producto con ID: {Id}", id);

            if (id != updateDto.IdProducto)
            {
                _logger.LogWarning("ID de ruta {Id} no coincide con ID del cuerpo {BodyId}",
                    id, updateDto.IdProducto);
                return BadRequest(new { error = "El ID del producto no coincide" });
            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al actualizar producto");
                return BadRequest(ModelState);
            }

            var existingproducto = await _productoservice.ObtenerPorIdAsync(id);
            if (existingproducto == null)
            {
                _logger.LogWarning("Producto con ID {Id} no encontrado para actualizar", id);
                return NotFound(new { error = "Producto no encontrado" });
            }

            _mapper.Map(updateDto, existingproducto);
            var (ok, error) = await _productoservice.ActualizarAsync(existingproducto);

            if (!ok)
            {
                _logger.LogWarning("Error al actualizar producto: {Error}", error);
                return BadRequest(new { error });
            }

            var productoDto = _mapper.Map<ProductoDto>(existingproducto);

            _logger.LogInformation("producto con ID {Id} actualizado exitosamente", id);

            return Ok(new { message = "producto actualizado exitosamente", producto = productoDto });
        }

        [Authorize(Roles = "Gerente")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("Eliminando producto con ID: {Id}", id);

            if (id <= 0)
            {
                _logger.LogWarning("ID de producto no válido: {Id}", id);
                return BadRequest(new { error = "ID de producto no válido" });
            }

            var existingCliente = await _productoservice.ObtenerPorIdAsync(id);
            if (existingCliente == null)
            {
                _logger.LogWarning("producto con ID {Id} no encontrado para eliminar", id);
                return NotFound(new { error = "producto no encontrado" });
            }

            var (ok, error) = await _productoservice.EliminarAsync(id);

            if (!ok)
            {
                _logger.LogWarning("Error al eliminar producto: {Error}", error);
                return BadRequest(new { error });
            }

            _logger.LogInformation("Producto con ID {Id} eliminado exitosamente", id);

            return NoContent();
        }
    }
}

