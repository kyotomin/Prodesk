namespace Prodesk.App;

using Npgsql;
using Prodesk.Infrastructure;

public partial class Form1 : Form
{
    private readonly PostgresConnectionFactory _dbFactory;

    public Form1(PostgresConnectionFactory dbFactory)
    {
        InitializeComponent();
        ConfigureProjectsGrid();
        _dbFactory = dbFactory;
    }

    private void ConfigureProjectsGrid()
    {
        ProjectsGridView.AutoGenerateColumns = false;
        ProjectsGridView.Columns.Clear();

        ProjectsGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "TitleColumn",
            HeaderText = "Название проекта",
            DataPropertyName = "Title",
            FillWeight = 30
        });

        ProjectsGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "DescriptionColumn",
            HeaderText = "Описание",
            DataPropertyName = "Description",
            FillWeight = 40
        });

        ProjectsGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "StatusColumn",
            HeaderText = "Статус",
            DataPropertyName = "Status",
            FillWeight = 15
        });

        ProjectsGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "CreatedAtColumn",
            HeaderText = "Дата создания",
            DataPropertyName = "CreatedAt",
            FillWeight = 15
        });
    }
}
