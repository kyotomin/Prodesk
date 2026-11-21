namespace Prodesk.Infrastructure;

using Npgsql;

public sealed class PostgresConnectionFactory : IDisposable
{
    private readonly NpgsqlDataSource _dataSource;

    public PostgresConnectionFactory(string connectionString)
    {
        _dataSource = NpgsqlDataSource.Create(connectionString);
    }

    public async Task<NpgsqlConnection> CreateConnectionAsync()
    {
        return await _dataSource.OpenConnectionAsync();
    }

    public void Dispose()
    {
        _dataSource.Dispose();
    }

}