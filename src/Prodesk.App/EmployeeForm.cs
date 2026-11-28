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

namespace Prodesk.App;

public partial class EmployeeForm : Form
{
    private readonly Guid _employeeId;
    private readonly DateTime _createdAt;

    public Employee? CreatedEmployee { get; private set; }

    public EmployeeForm(Employee? employee = null)
    {
        InitializeComponent();

        SaveButton.Click += SaveButton_Click;
        CloseButton.Click += CancelButton_Click;

        if (employee == null)
        {
            return;
        }

        _employeeId = employee.Id;
        _createdAt = employee.CreatedAt;

        FullNameTextBox.Text = employee.FullName;
        EmailTextBox.Text = employee.Email;
        PositionTextBox.Text = employee.Position;
        ExperienceYearsNumericUpDown.Value = employee.ExperienceYears;
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(FullNameTextBox.Text))
        {
            MessageBox.Show("Введите ФИО сотрудника.");
            return;
        }

        if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
        {
            MessageBox.Show("Введите email сотрудника.");
            return;
        }

        if (string.IsNullOrWhiteSpace(PositionTextBox.Text))
        {
            MessageBox.Show("Введите должность сотрудника.");
            return;
        }

        CreatedEmployee = new Employee
        {
            Id = _employeeId,
            CreatedAt = _createdAt,
            FullName = FullNameTextBox.Text.Trim(),
            Email = EmailTextBox.Text.Trim(),
            Position = PositionTextBox.Text.Trim(),
            ExperienceYears = (int)ExperienceYearsNumericUpDown.Value
        };

        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
