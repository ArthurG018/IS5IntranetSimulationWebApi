using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface
{
    public interface IProfessorRepository
    {
        #region CRUD
        bool InsertProfessor(Professor professor);
        bool InsertAllProfessor(String consulta);
        Professor GetProfessor(int id);
        IEnumerable<Professor> GetAllProfessor();
        #endregion
    }
}
