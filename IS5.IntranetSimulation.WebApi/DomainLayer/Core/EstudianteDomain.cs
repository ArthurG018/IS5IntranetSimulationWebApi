using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Repository;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Core
{
    public class EstudianteDomain:IEstudianteDomain
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudianteDomain(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }
        #region CRUD
        public bool InsertEstudiante(Estudiante estudiante)
        {
            return _estudianteRepository.InsertEstudiante(estudiante);
        }
        public bool InsertAllEstudiante(IEnumerable<Estudiante> estudiantes)
        {
            String consulta = "";
            foreach (Estudiante estudiante in estudiantes)
            {
                String separator = (estudiante == estudiantes.Last()) ? ";" : ",";
                consulta += $"('{estudiante.codigo_universitario_estudiante}','{estudiante.nombre_completo_estudiante}','{estudiante.ficha_matricula_estudiante}','" +
                            $"{estudiante.ciclo_estudiante}','{estudiante.escuela_estudiante}'){separator} ";
            }
            return _estudianteRepository.InsertAllEstudiante(consulta);
        }
        public Estudiante GetEstudiante(int id)
        {
            return _estudianteRepository.GetEstudiante(id);
        }
        public IEnumerable<Estudiante> GetAllEstudiante()
        {
            return _estudianteRepository.GetAllEstudiante();
        }
        #endregion
    }
}
