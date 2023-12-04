using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace IS5.IntranetSimulation.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        private readonly IDocenteDomain _docenteDomain;

        public DocenteController(IDocenteDomain docenteDomain)
        {
            _docenteDomain = docenteDomain;
        }

        [HttpPost]
        [ActionName("InsertAll")]
        public IActionResult InsertAll([FromBody] IEnumerable<Docente> docentes)
        {
            if (docentes == null) return BadRequest();
            var response = _docenteDomain.InsertAllDocente(docentes);
            if (response)
            {
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpPost]
        [ActionName("Insert")]
        public IActionResult Insert([FromBody] Docente docente)
        {
            if (docente == null) return BadRequest();
            var response = _docenteDomain.InsertDocente(docente);
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
            var response = _docenteDomain.GetDocente(id);
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
            var response = _docenteDomain.GetAllDocente();
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest();
        }

    }
}
