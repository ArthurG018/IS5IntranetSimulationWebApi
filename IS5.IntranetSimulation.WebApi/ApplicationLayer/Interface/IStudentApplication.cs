using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;

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
    }
}
