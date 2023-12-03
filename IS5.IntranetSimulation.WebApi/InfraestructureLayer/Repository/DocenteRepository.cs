using Dapper;
using IS5.IntranetSimulation.WebApi.CrossLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using System.Data;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Repository
{
    public class DocenteRepository:IDocenteRepository
    {
        private readonly IConnectionDataBase _connection;

        public DocenteRepository(IConnectionDataBase connection)
        {
            _connection = connection;
        }
        #region CRUD
        public bool InsertDocente(Docente docente)
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "";
                var parameters = new DynamicParameters();
                parameters.Add("", docente.nombre_completo_docente);

                var result = dbConnection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool InsertAllDocente(String consulta)
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "InsertAllDocente";
                var parameters = new DynamicParameters();
                parameters.Add("Consulta", consulta);

                var result = dbConnection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public Docente GetDocente(int id)
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "";
                var parameters = new DynamicParameters();
                parameters.Add("", id);

                var result = dbConnection.QuerySingle<Docente>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public IEnumerable<Docente> GetAllDocente()
        {
            using (var dbConnection = _connection.GetConnection)
            {
                var query = "GetAllDocente";

                var result = dbConnection.Query<Docente>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion
    }
}
