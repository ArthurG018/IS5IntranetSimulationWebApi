using Dapper;
using IS5.IntranetSimulation.WebApi.CrossLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using IS5.IntranetSimulation.WebApi.Modules.HelperMapping;
using System.Data;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly IConnectionDataBase _connection;

        public ProfessorRepository(IConnectionDataBase connection)
        {
            _connection = connection;
        }

        #region CRUD
        public bool InsertProfessor(Professor professor)
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "sp_insert_professor";
                var parameters = new DynamicParameters();
                parameters.Add("full_name", professor.FullName);
                parameters.Add("dni", professor.Dni);

                var result = dbConnection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool InsertAllProfessor(String consulta)
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "sp_insert_all_professors";
                var parameters = new DynamicParameters();
                parameters.Add("query", consulta);

                var result = dbConnection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public Professor GetProfessor(int id)
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "sp_get_professor_by_id";
                var parameters = new DynamicParameters();
                parameters.Add("professor_id", id);

                MappingForDescription.MapProfessor();

                var result = dbConnection.QuerySingle<Professor>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public IEnumerable<Professor> GetAllProfessor()
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "sp_get_all_professors";

                MappingForDescription.MapProfessor();

                var result = dbConnection.Query<Professor>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion
    }
}
