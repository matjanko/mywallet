using System.Data;

namespace MyWallet.Abstractions.Dabatase;

public interface ISqlConnectionFactory
{
    IDbConnection GetConnection();
}