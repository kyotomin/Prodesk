using Npgsql;

public sealed class PostgresConnectionFactory : IDisposable
{
    private readonly NpgsqlDataSource _dataSource;

    public PostgresConnectionFactory(string connString)
    {
        _dataSource = Np
    }

}