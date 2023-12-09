using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using IS5.IntranetSimulation.WebApi.Modules.Helpers;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Core
{
    public class ProfessorDomain:IProfessorDomain
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorDomain(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }
        #region CRUD
        public bool InsertProfessor(Professor professor)
        {
            return _professorRepository.InsertProfessor(professor);
        }
        public bool InsertAllProfessor(IEnumerable<Professor> professors)
        {
            String consulta = "";
            foreach (Professor professor in professors)
            {
                String separator = (professor == professors.Last()) ? ";" :"," ;
                consulta += $"('{professor.FullName}', '{professor.Dni}'){separator} ";
            }
            return _professorRepository.InsertAllProfessor(consulta);
        }
        public Professor GetProfessor(int id)
        {
            return RemoveSpaces.RemoveSpaceProfessor(_professorRepository.GetProfessor(id));
        }
        public IEnumerable<Professor> GetAllProfessor()
        {
            return RemoveSpaces.RemoveSpaceListProfessor(_professorRepository.GetAllProfessor());
        }
        #endregion

        #region SERVICIO   
        public bool ValidateDni(String dni)
        {
            var professor = _professorRepository.GetAllProfessor().Where(x=>x.Dni.Equals(dni));
            return (professor.Count() > 0) ;
        }
        #endregion
    }
}
