using Actividad6.Data;
using Actividad6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Actividad6.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Swagger necesita esta ruta para detectar los endpoints
    public class PanaderiaController : ControllerBase
    {
        private readonly IPanaderiaService _panaderiaService;

        public PanaderiaController(IPanaderiaService panaderiaService)
        {
            _panaderiaService = panaderiaService;
        }

        // Endpoint para obtener todas las panaderías
        [HttpGet]
        public async Task<IActionResult> GetPanaderias()
        {
            var panaderias =  _panaderiaService.ObtenerPanaderias();
            return Ok(panaderias); // Devuelve un HTTP 200 con la lista de panaderías
        }

        // Endpoint para agregar una nueva panadería
        [HttpPost]
        public async Task<IActionResult> AddPanaderia([FromBody] Panaderia panaderia)
        {
            if (panaderia == null)
                return BadRequest("La panadería no puede ser nula");

            _panaderiaService.AgregarPanaderia(panaderia);
            return Ok("Panadería agregada correctamente");
        }
    }
}