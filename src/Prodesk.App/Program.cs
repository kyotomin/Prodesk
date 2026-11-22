namespace Prodesk.App;

using DotNetEnv;
using Npgsql;
using Prodesk.Infrastructure;

static class Program
{
    [STAThread]
    static void Main()
    {
        Env.Load();

        var connectionString = GetConnectionString();

        using var dbFactory = new PostgresConnectionFactory(connectionString);

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(dbFactory));
    }    

    public static string GetConnectionString()
    {
        var host = Environment.GetEnvironmentVariable("DB_HOST");
        var port = Environment.GetEnvironmentVariable("DB_PORT");
        var database = Environment.GetEnvironmentVariable("DB_NAME");
        var user = Environment.GetEnvironmentVariable("DB_USER");
        var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

        var builder = new NpgsqlConnectionStringBuilder
        {
            Host = host,
            Port = int.Parse(port!),
            Database = database,
            Username = user,
            Password = password
        };


        return builder.ConnectionString;
    }
}