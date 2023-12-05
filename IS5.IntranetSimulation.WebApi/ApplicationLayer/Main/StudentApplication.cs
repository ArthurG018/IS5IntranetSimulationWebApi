using AutoMapper;
using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;
using IS5.IntranetSimulation.WebApi.ApplicationLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;

namespace IS5.IntranetSimulation.WebApi.ApplicationLayer.Main
{
    public class StudentApplication:IStudentApplication
    {
        private readonly IStudentDomain _studentDomain;
        private readonly IMapper _mapper;

        public StudentApplication(IStudentDomain studentDomain, IMapper mapper)
        {
            _studentDomain = studentDomain;
            _mapper = mapper;
        }

        #region CRUD
        public bool InsertStudent(StudentDto studentDto)
        {
            try
            {
                var student = _mapper.Map<Student>(studentDto);
                return _studentDomain.InsertStudent(student);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public bool InsertAllStudent(IEnumerable<StudentDto> studentsDto)
        {
            try
            {
                var students = _mapper.Map<IEnumerable<Student>>(studentsDto);
                return _studentDomain.InsertAllStudent(students);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public StudentDto GetStudent(int id)
        {
            try
            {
                var student = _studentDomain.GetStudent(id);
                var studentDto = _mapper.Map<StudentDto>(student);
                return studentDto;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<StudentDto> GetAllStudent()
        {
            try
            {
                var students = _studentDomain.GetAllStudent();
                var studentsDto = _mapper.Map<IEnumerable<StudentDto>>(students);
                return studentsDto;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
