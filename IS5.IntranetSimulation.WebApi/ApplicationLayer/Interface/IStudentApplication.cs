using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.ApplicationLayer.Interface
{
    public interface IStudentApplication
    {
        #region CRUD
        bool InsertStudent(StudentDto studentDto);
        bool InsertAllStudent(IEnumerable<StudentDto> studentsDto);
        StudentDto GetStudent(int id);
        IEnumerable<StudentDto> GetAllStudent();
        #endregion

        #region SERVICIO
        IEnumerable<StudentDto> GetAllSemesterSchool(String semester, String school);
        #endregion
    }
}
