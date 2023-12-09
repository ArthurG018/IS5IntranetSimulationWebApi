using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;

namespace IS5.IntranetSimulation.WebApi.AplicationLayer.Interface
{
    public interface IProfesorApplication
    {
        #region CRUD
        bool InsertProfessor(ProfessorDto professorDto);
        bool InsertAllProfessor(IEnumerable<ProfessorDto> professorsDto);
        ProfessorDto GetProfessor(int id);
        IEnumerable<ProfessorDto> GetAllProfessor();
        #endregion

        #region SERVICIO   
        bool ValidateDni(String dni);
        #endregion
    }
}
