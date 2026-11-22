namespace Prodesk.App;

using Npgsql;
using Prodesk.Infrastructure;

public partial class Form1 : Form
{
    private readonly PostgresConnectionFactory _dbFactory;

    public Form1(PostgresConnectionFactory dbFactory)
    {
        InitializeComponent();
        _dbFactory = dbFactory;
    }

    private async void btnTestConnection_Click(object sender, EventArgs e)
    {
        try
        {
            await using var connection =
                await _dbFactory.CreateConnectionAsync();

            await using var command =
                new NpgsqlCommand("SELECT version()", connection);

            var result = await command.ExecuteScalarAsync();

            MessageBox.Show(
                result?.ToString(),
                "Database connection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Database error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
