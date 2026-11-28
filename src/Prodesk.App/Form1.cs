namespace Prodesk.App;

using System.Threading.Tasks;
using Prodesk.Core.Entities;
using Prodesk.Core.Repositories;
using Prodesk.Infrastructure;
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
        Load += Form1_Load; // Предзагрузка проектов (подписка на обработчик)
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

    private async void AddProjectButton_Click(object sender, EventArgs e)
    {
        using var form = new AddProjectForm();

        if (form.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }
        ;

        var project = form.CreatedProject!;

        try
        {
            await _projectRepository.AddAsync(project);

            var projects = await _projectRepository.GetAllAsync();
            ProjectsGridView.DataSource = projects;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка сохранения",
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

    private void ProjectsGridView_SelectionChanged(object sender, EventArgs e)
    {
        bool hasSelection = ProjectsGridView.SelectedRows.Count > 0;

        EditProjectButton.Enabled = hasSelection;
        DeleteProjectButton.Enabled = hasSelection;
    }

    private Project? GetSelectedProject()
    {
        if (ProjectsGridView.SelectedRows.Count == 0)
        {
            return null;
        }
        ;

        return ProjectsGridView.SelectedRows[0].DataBoundItem as Project;
    }

    private async void EditProjectButton_Click(object sender, EventArgs e)
    {
        var project = GetSelectedProject();

        if (project == null)
        {
            return;
        }
        ;

        using var form = new AddProjectForm(project);

        if (form.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }
        ;

        var updatedProject = form.CreatedProject!;

        try
        {
            await _projectRepository.UpdateAsync(updatedProject);

            var projects = await _projectRepository.GetAllAsync();
            ProjectsGridView.DataSource = projects;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка редактирования");
        }
    }

    private async Task LoadProjectsAsync()
    {
        var projects = await _projectRepository.GetAllAsync();
        ProjectsGridView.DataSource = projects;
    }

    private async void DeleteProjectButton_Click(object sender, EventArgs e)
    {
        var project = GetSelectedProject();

        if (project == null) 
        { 
            return;
        };

        var result = MessageBox.Show(
        $"Удалить проект «{project.Title}»?",
        "Подтверждение удаления",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

        if (result != DialogResult.Yes) 
        {
            return;
        };

        try
        {
            await _projectRepository.DeleteAsync(project.Id);
            await LoadProjectsAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка удаления");
        }
    }
}
