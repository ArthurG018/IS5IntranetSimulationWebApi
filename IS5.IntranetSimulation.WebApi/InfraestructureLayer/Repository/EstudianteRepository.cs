using Dapper;
using IS5.IntranetSimulation.WebApi.CrossLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using System.Data;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Repository
{
    public class EstudianteRepository:IEstudianteRepository
    {
        private readonly IConnectionDataBase _connection;

        public EstudianteRepository(IConnectionDataBase connection)
        {
            _connection = connection;
        }
        #region CRUD
        public bool InsertEstudiante(Estudiante estudiante)
        {
            using (var db = _connection.GetConnection)
            {
                var query = "InsertEstudiante";
                var parameters = new DynamicParameters();
                parameters.Add("Codigo", estudiante.codigo_universitario_estudiante);
                parameters.Add("Nombre", estudiante.nombre_completo_estudiante);
                parameters.Add("Ficha", estudiante.ficha_matricula_estudiante);
                parameters.Add("Ciclo", estudiante.ciclo_estudiante);
                parameters.Add("Escuela", estudiante.escuela_estudiante);

                var result = db.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public bool InsertAllEstudiante(String consulta)
        {
            using (var db = _connection.GetConnection)
            {
                var query = "InsertAllEstudiante";
                var parameters = new DynamicParameters();
                parameters.Add("Consulta", consulta);

                var result = db.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public Estudiante GetEstudiante(int id)
        {
            using (var db = _connection.GetConnection)
            {
                var query = "GetEstudiante";
                var parameters = new DynamicParameters();
                parameters.Add("id", id);

                var result = db.QuerySingle<Estudiante>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public IEnumerable<Estudiante> GetAllEstudiante()
        {
            using (var db = _connection.GetConnection)
            {
                var query = "GetAllEstudiante";

                var result = db.Query<Estudiante>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion
    }
}
