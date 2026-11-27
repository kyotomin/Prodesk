namespace Prodesk.App;

using Prodesk.Infrastructure;
using Prodesk.Core.Repositories;
using Prodesk.Infrastructure.Repositories;

public partial class Form1 : Form
{
    private readonly PostgresConnectionFactory _dbFactory;
    private readonly IProjectRepository _projectRepository;

    public Form1(PostgresConnectionFactory dbFactory)
    {
        _dbFactory = dbFactory;
        _projectRepository = new PostgresProjectRepository(dbFactory);
        InitializeComponent();
        ConfigureProjectsGrid();
        Load += Form1_Load;
    }

    private async void Form1_Load(object? sender, EventArgs e)
    {
        try
        {
            var projects = await _projectRepository.GetAllAsync();

            ProjectsGridView.DataSource = projects;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Не удалось загрузить проекты:\n{ex.Message}",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
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
            FillWeight = 15,

            DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = "dd.MM.yyyy"
            }
        });
    }
}
