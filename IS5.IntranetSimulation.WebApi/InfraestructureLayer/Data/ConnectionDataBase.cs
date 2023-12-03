using System.Data.SqlClient;
using System.Data;
using IS5.IntranetSimulation.WebApi.CrossLayer.Interface;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Data
{
    public class ConnectionDataBase:IConnectionDataBase
    {
        private readonly IConfiguration _configuration;

        public ConnectionDataBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var sqlConection = new SqlConnection();
                if (sqlConection == null) return null;
                sqlConection.ConnectionString = _configuration.GetConnectionString("ConnectionDB");
                sqlConection.Open();
                return sqlConection;
            }
        }
    }
}
