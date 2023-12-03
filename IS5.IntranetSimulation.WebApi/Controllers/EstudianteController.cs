using IS5.IntranetSimulation.WebApi.DomainLayer.Core;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using Microsoft.AspNetCore.Http;
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
