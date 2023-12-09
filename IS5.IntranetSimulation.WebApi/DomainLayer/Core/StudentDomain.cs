using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using IS5.IntranetSimulation.WebApi.Modules.Helpers;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Core
{
    public class StudentDomain:IStudentDomain
    {
        private readonly IStudentRepository _studentRepository;

        public StudentDomain(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #region CRUD
        public bool InsertStudent(Student student)
        {
            return _studentRepository.InsertStudent(student);
        }
        public bool InsertAllStudent(IEnumerable<Student> students)
        {
            String consulta = "";
            foreach (Student student in students)
            {
                String separator = (student == students.Last()) ? ";" : ",";
                consulta += $"('{student.UniversityCode}','{student.FullName}','{student.RegistrationFormNumber}','" +
                            $"{student.Semester}','{student.School}'){separator} ";
            }
            return _studentRepository.InsertAllStudent(consulta);
        }
        public Student GetStudent(int id)
        {
            return RemoveSpaces.RemoveSpaceStudent(_studentRepository.GetStudent(id));
        }
        public IEnumerable<Student> GetAllStudent()
        {
            return RemoveSpaces.RemoveSpaceListStudent(_studentRepository.GetAllStudent());
        }
        #endregion

        #region SERVICIO
        public IEnumerable<Student> GetAllSemesterSchool(String semester, String school)
        {
            var students = _studentRepository.GetAllStudent().Where(x=>x.Semester.Equals(semester) && x.School.Equals(school));
            return students;
        }
        #endregion
    }
}
