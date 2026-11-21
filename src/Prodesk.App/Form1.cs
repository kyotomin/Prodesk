namespace Prodesk.App;
using Prodesk.Infrastructure;

public partial class Form1 : Form
{
    private readonly PostgresConnectionFactory _dbFactory;

    public Form1(PostgresConnectionFactory dbFactory)
    {
        InitializeComponent();
        _dbFactory = _dbFactory;
    }
}
