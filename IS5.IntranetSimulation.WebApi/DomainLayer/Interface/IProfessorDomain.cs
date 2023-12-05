using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Interface
{
    public interface IProfessorDomain
    {
        #region CRUD
        bool InsertProfessor(Professor professor);
        bool InsertAllProfessor(IEnumerable<Professor> professors);
        Professor GetProfessor(int id);
        IEnumerable<Professor> GetAllProfessor();
        #endregion
    }
}
