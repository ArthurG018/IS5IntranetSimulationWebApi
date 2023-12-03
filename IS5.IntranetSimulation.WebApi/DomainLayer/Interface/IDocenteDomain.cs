using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using System.Collections;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Interface
{
    public interface IDocenteDomain
    {
        #region CRUD
        bool InsertDocente(Docente docente);
        bool InsertAllDocente(IEnumerable<Docente> docentes);
        Docente GetDocente(int id);
        IEnumerable<Docente> GetAllDocente();
        #endregion
    }
}
