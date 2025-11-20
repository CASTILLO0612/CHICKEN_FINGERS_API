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
    public class CategoriaController : ControllerBase
    {
        private readonly IService<Categoria> _service;
        private readonly ILogger<CategoriaController> _logger;
        private readonly IMapper _mapper;

        public CategoriaController(
            IService<Categoria> categoriaService,
            ILogger<CategoriaController> logger,
            IMapper mapper)
        {
            _service = categoriaService;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<IEnumerable<CategoriaDto>>> GetAll()
        {
            _logger.LogInformation("Obteniendo todas las categorías");

            var categorias = await _service.ListarAsync();
            return Ok(_mapper.Map<IEnumerable<CategoriaDto>>(categorias));
        }

        [Authorize(Roles = "Gerente")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoriaDto>> CreateCategoria([FromBody] CategoriaCreateDto createDto)
        {
            _logger.LogInformation("Creando nueva categoría");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al crear categoría");
                return BadRequest(ModelState);
            }

            var entidad = _mapper.Map<Categoria>(createDto);
            var (ok, error) = await _service.CrearAsync(entidad);

            if (!ok)
            {
                _logger.LogWarning("Error al crear categoría: {Error}", error);
                return BadRequest(new { error });
            }

            var categoriaDto = _mapper.Map<CategoriaDto>(entidad);
            _logger.LogInformation("Categoría creada exitosamente");

            return Ok(new { message = "Categoría creada exitosamente", Categoria = categoriaDto });
        }

        [Authorize(Roles = "Gerente")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaDto>> UpdateCategoria(int id, [FromBody] CategoriaCreateDto updateDto)
        {
            _logger.LogInformation("Actualizando categoría con ID: {Id}", id);

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al actualizar categoría");
                return BadRequest(ModelState);
            }

            var existingCategoria = await _service.ObtenerPorIdAsync(id);
            if (existingCategoria == null)
            {
                _logger.LogWarning("Categoría con ID {Id} no encontrada para actualizar", id);
                return NotFound(new { error = "Categoría no encontrada" });
            }

            _mapper.Map(updateDto, existingCategoria);
            var (ok, error) = await _service.ActualizarAsync(existingCategoria);

            if (!ok)
            {
                _logger.LogWarning("Error al actualizar categoría: {Error}", error);
                return BadRequest(new { error });
            }

            var categoriaDto = _mapper.Map<CategoriaDto>(existingCategoria);
            _logger.LogInformation("Categoría con ID {Id} actualizada exitosamente", id);

            return Ok(new { message = "Categoría actualizada exitosamente", Categoria = categoriaDto });
        }

        [Authorize(Roles = "Gerente")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("Eliminando categoría con ID: {Id}", id);

            if (id <= 0)
            {
                _logger.LogWarning("ID de categoría no válido: {Id}", id);
                return BadRequest(new { error = "ID de categoría no válido" });
            }

            var existingCategoria = await _service.ObtenerPorIdAsync(id);
            if (existingCategoria == null)
            {
                _logger.LogWarning("Categoría con ID {Id} no encontrada para eliminar", id);
                return NotFound(new { error = "Categoría no encontrada" });
            }

            var (ok, error) = await _service.EliminarAsync(id);
            if (!ok)
            {
                _logger.LogWarning("Error al eliminar categoría: {Error}", error);
                return BadRequest(new { error });
            }

            _logger.LogInformation("Categoría con ID {Id} eliminada exitosamente", id);

            return NoContent();
        }

        [Authorize(Roles = "Vendedor,Gerente")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaDto>> GetById(int id)
        {
            _logger.LogInformation("Obteniendo categoría con ID: {Id}", id);

            if (id <= 0)
            {
                _logger.LogWarning("ID de categoría no válido: {Id}", id);
                return BadRequest(new { error = "ID de categoría no válido" });
            }

            var categoria = await _service.ObtenerPorIdAsync(id);
            if (categoria == null)
            {
                _logger.LogWarning("Categoría con ID {Id} no encontrada", id);
                return NotFound(new { error = "Categoría no encontrada" });
            }

            var categoriaDto = _mapper.Map<CategoriaDto>(categoria);
            return Ok(categoriaDto);
        }
    }
}

