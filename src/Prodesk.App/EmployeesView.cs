using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prodesk.Core.Entities;
using Prodesk.Infrastructure;
using Prodesk.Infrastructure.Repositories;

namespace Prodesk.App;

public partial class EmployeesView : UserControl
{
    private readonly PostgresEmployeeRepository _employeeRepository;

    public EmployeesView(PostgresConnectionFactory dbFactory)
    {
        InitializeComponent();

        _employeeRepository = new PostgresEmployeeRepository(dbFactory);

        ConfigureEmployeesGrid();

        EditEmployeeButton.Enabled = false;
        DeleteEmployeeButton.Enabled = false;

        EmployeesGridView.SelectionChanged += EmployeesGridView_SelectionChanged;

        AddEmployeeButton.Click += AddEmployeeButton_Click;
        EditEmployeeButton.Click += EditEmployeeButton_Click;
        DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
    }

    private void ConfigureEmployeesGrid()
    {
        EmployeesGridView.AutoGenerateColumns = false;
        EmployeesGridView.Columns.Clear();

        EmployeesGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "FullNameColumn",
            HeaderText = "ФИО",
            DataPropertyName = "FullName",
            FillWeight = 25
        });

        EmployeesGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "EmailColumn",
            HeaderText = "Email",
            DataPropertyName = "Email",
            FillWeight = 25
        });

        EmployeesGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "PositionColumn",
            HeaderText = "Должность",
            DataPropertyName = "Position",
            FillWeight = 20
        });

        EmployeesGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ExperienceColumn",
            HeaderText = "Опыт (лет)",
            DataPropertyName = "ExperienceYears",
            FillWeight = 10
        });

        EmployeesGridView.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "CreatedAtColumn",
            HeaderText = "Дата добавления",
            DataPropertyName = "CreatedAt",
            FillWeight = 15,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = "dd.MM.yyyy"
            }
        });
    }

    public async Task LoadEmployeesAsync()
    {
        try
        {
            var employees = await _employeeRepository.GetAllAsync();
            EmployeesGridView.DataSource = employees;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Не удалось загрузить сотрудников:\n{ex.Message}",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private Employee? GetSelectedEmployee()
    {
        if (EmployeesGridView.SelectedRows.Count == 0)
        {
            return null;
        }

        return EmployeesGridView.SelectedRows[0].DataBoundItem as Employee;
    }

    private void EmployeesGridView_SelectionChanged(object? sender, EventArgs e)
    {
        bool hasSelection = EmployeesGridView.SelectedRows.Count > 0;

        EditEmployeeButton.Enabled = hasSelection;
        DeleteEmployeeButton.Enabled = hasSelection;
    }

    private async void AddEmployeeButton_Click(object? sender, EventArgs e)
    {
        using var form = new EmployeeForm();

        if (form.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            await _employeeRepository.AddAsync(form.CreatedEmployee!);
            await LoadEmployeesAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка добавления",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async void EditEmployeeButton_Click(object? sender, EventArgs e)
    {
        var employee = GetSelectedEmployee();

        if (employee == null)
        {
            return;
        }

        using var form = new EmployeeForm(employee);

        if (form.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            await _employeeRepository.UpdateAsync(form.CreatedEmployee!);
            await LoadEmployeesAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка редактирования",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async void DeleteEmployeeButton_Click(object? sender, EventArgs e)
    {
        var employee = GetSelectedEmployee();

        if (employee == null)
        {
            return;
        }

        var result = MessageBox.Show(
            $"Удалить сотрудника «{employee.FullName}»?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (result != DialogResult.Yes)
        {
            return;
        }

        try
        {
            await _employeeRepository.DeleteAsync(employee.Id);
            await LoadEmployeesAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка удаления",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
