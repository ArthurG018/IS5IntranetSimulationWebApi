using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using System.Collections;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Core
{
    public class DocenteDomain:IDocenteDomain
    {
        private readonly IDocenteRepository _docenteRepository;

        public DocenteDomain(IDocenteRepository docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }
        #region CRUD
        public bool InsertDocente(Docente docente)
        {
            return _docenteRepository.InsertDocente(docente);
        }
        public bool InsertAllDocente(IEnumerable<Docente> docentes)
        {
            String consulta = "";
            String tableName = "docente";
            foreach (Docente docente in docentes)
            {
                consulta += "INSERT INTO "+tableName+" (nombre_completo_docente) VALUES ('"+docente.nombre_completo_docente+"'); ";
            }
            return _docenteRepository.InsertAllDocente(consulta);
        }
        public Docente GetDocente(int id)
        {
            return _docenteRepository.GetDocente(id);
        }
        public IEnumerable<Docente> GetAllDocente()
        {
            return _docenteRepository.GetAllDocente();
        }
        #endregion
    }
}
