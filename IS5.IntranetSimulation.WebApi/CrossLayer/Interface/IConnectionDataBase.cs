using System.Data;

namespace IS5.IntranetSimulation.WebApi.CrossLayer.Interface
{
    public interface IConnectionDataBase
    {
        IDbConnection GetConnection { get; }
    }
}
