using System.Data;

namespace CorePoint.Infrastructure;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}
