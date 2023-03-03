using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P01WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace P01WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContext;

        public equiposController(equiposContext equiposContexto)
        {
            _equiposContext = equiposContexto;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult ObtenerEquipos()
        {
            List<equipos> ListadoEquipos = (from e in _equiposContext.equipos
                                            select e).ToList();



            if (ListadoEquipos.Count == 0)
            {
                return NotFound();
            }

            return Ok(ListadoEquipos);
        }
    }
}
