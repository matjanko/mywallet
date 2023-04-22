using System.Data;
using System.Data.Common;
using MyWallet.Abstractions.Dabatase;
using Npgsql;

namespace MyWallet.Infrastructure.Postgres;

internal class NpgsqlConnectionFactory : ISqlConnectionFactory, IDisposable
{
    private readonly string _connectionString;
    private IDbConnection? _connection;
    
    public NpgsqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public IDbConnection GetConnection()
    {
        if (_connection == null || _connection.State == ConnectionState.Open)
        {
            _connection = new NpgsqlConnection(_connectionString);    
        }
        
        return _connection;
    }

    public void Dispose()
    {
        if (_connection is { State: ConnectionState.Open })
        {
            _connection.Dispose();
        }
    }
}