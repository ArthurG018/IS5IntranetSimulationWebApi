using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface
{
    public interface IDocenteRepository
    {
        #region CRUD
        bool InsertDocente(Docente docente);
        bool InsertAllDocente(String consulta);
        Docente GetDocente(int id);
        IEnumerable<Docente> GetAllDocente();
        #endregion
    }
}
