using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface
{
    public interface IEstudianteRepository
    {
        #region CRUD
        bool InsertEstudiante(Estudiante estudiante);
        bool InsertAllEstudiante(String consulta);
        Estudiante GetEstudiante(int id);
        IEnumerable<Estudiante> GetAllEstudiante();
        #endregion
    }
}
