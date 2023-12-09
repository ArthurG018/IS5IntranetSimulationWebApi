using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Interface
{
    public interface IStudentDomain
    {
        #region CRUD
        bool InsertStudent(Student student);
        bool InsertAllStudent(IEnumerable<Student> students);
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudent();
        #endregion

        #region SERVICIO
        IEnumerable<Student> GetAllSemesterSchool(String semester, String school);
        #endregion
    }
}
