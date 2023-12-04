using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using Microsoft.AspNetCore.Mvc;

namespace IS5.IntranetSimulation.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteDomain _estudianteDomain;

        public EstudianteController(IEstudianteDomain estudianteDomain)
        {
            _estudianteDomain = estudianteDomain;
        }

        [HttpPost]
        [ActionName("InsertAll")]
        public IActionResult InsertAll([FromBody] IEnumerable<Estudiante> estudiantes)
        {
            if (estudiantes == null) return BadRequest();
            var response = _estudianteDomain.InsertAllEstudiante(estudiantes);
            if (response)
            {
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpPost]
        [ActionName("Insert")]
        public IActionResult Insert([FromBody] Estudiante estudiante)
        {
            if (estudiante == null) return BadRequest();
            var response = _estudianteDomain.InsertEstudiante(estudiante);
            if (response)
            {
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpGet]
        [ActionName("Get")]
        public IActionResult Get(int id)
        {
            var response = _estudianteDomain.GetEstudiante(id);
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpGet]
        [ActionName("GetAll")]
        public IActionResult GetAll()
        {
            var response = _estudianteDomain.GetAllEstudiante();
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
