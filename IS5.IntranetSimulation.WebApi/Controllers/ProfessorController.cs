using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;
using IS5.IntranetSimulation.WebApi.AplicationLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace IS5.IntranetSimulation.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfesorApplication _profesorApplication;

        public ProfessorController(IProfesorApplication profesorApplication)
        {
            _profesorApplication = profesorApplication;
        }

        [HttpPost]
        [ActionName("InsertAll")]
        public IActionResult InsertAll([FromBody] IEnumerable<ProfessorDto> professorsDto)
        {
            if (professorsDto == null) return BadRequest();
            var response = _profesorApplication.InsertAllProfessor(professorsDto);
            if (response)
            {
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpPost]
        [ActionName("Insert")]
        public IActionResult Insert([FromBody] ProfessorDto professorDto)
        {
            if (professorDto == null) return BadRequest();
            var response = _profesorApplication.InsertProfessor(professorDto);
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
            var response = _profesorApplication.GetProfessor(id);
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
            var response = _profesorApplication.GetAllProfessor();
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
