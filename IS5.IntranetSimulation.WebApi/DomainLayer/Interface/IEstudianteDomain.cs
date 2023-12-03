using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Interface
{
    public interface IEstudianteDomain
    {
        #region CRUD
        bool InsertEstudiante(Estudiante estudiante);
        bool InsertAllEstudiante(IEnumerable<Estudiante> estudiantes);
        Estudiante GetEstudiante(int id);
        IEnumerable<Estudiante> GetAllEstudiante();
        #endregion
    }
}
