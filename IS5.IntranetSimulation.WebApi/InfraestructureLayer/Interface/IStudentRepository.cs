using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface
{
    public interface IStudentRepository
    {
        #region CRUD
        bool InsertStudent(Student student);
        bool InsertAllStudent(String consulta);
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudent();
        #endregion
    }
}
