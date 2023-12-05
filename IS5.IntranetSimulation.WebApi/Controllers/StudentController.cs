using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;
using IS5.IntranetSimulation.WebApi.ApplicationLayer.Interface;
using Microsoft.AspNetCore.Mvc;

namespace IS5.IntranetSimulation.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentApplication _studentApplication;

        public StudentController(IStudentApplication studentApplication)
        {
            _studentApplication = studentApplication;
        }

        [HttpPost]
        [ActionName("InsertAll")]
        public IActionResult InsertAll([FromBody] IEnumerable<StudentDto> studentsDto)
        {
            if (studentsDto == null) return BadRequest();
            var response = _studentApplication.InsertAllStudent(studentsDto);
            if (response)
            {
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpPost]
        [ActionName("Insert")]
        public IActionResult Insert([FromBody] StudentDto studentDto)
        {
            if (studentDto == null) return BadRequest();
            var response = _studentApplication.InsertStudent(studentDto);
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
            var response = _studentApplication.GetStudent(id);
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
            var response = _studentApplication.GetAllStudent();
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
