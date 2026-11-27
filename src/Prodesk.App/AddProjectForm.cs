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

namespace Prodesk.App
{
    public partial class AddProjectForm : Form
    {
        public Project? CreatedProject { get; private set; }
        public AddProjectForm()
        {
            InitializeComponent();

            StatusComboBox.Items.Add("Планируется");
            StatusComboBox.Items.Add("В работе");
            StatusComboBox.Items.Add("Завершён");

            StatusComboBox.SelectedIndex = 0;
        }

        public AddProjectForm(Project project)
        {
            InitializeComponent();

            TitleTextBox.Text = project.Title;
            DescriptionTextBox.Text = project.Description;

            StatusComboBox.Items.Add("Планируется");
            StatusComboBox.Items.Add("В работе");
            StatusComboBox.Items.Add("Завершён");

            StatusComboBox.SelectedIndex = project.Status switch
            {
                ProjectStatus.Planned => 0,
                ProjectStatus.InProgress => 1,
                ProjectStatus.Finished => 2,
                _ => 0
            };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                MessageBox.Show("Введите название проекта.");
                return;
            }

            var status = StatusComboBox.SelectedIndex switch
            {
                0 => ProjectStatus.Planned,
                1 => ProjectStatus.InProgress,
                2 => ProjectStatus.Finished,
                _ => ProjectStatus.Planned
            };

            CreatedProject = new Project
            {
                Title = TitleTextBox.Text.Trim(),
                Description = string.IsNullOrWhiteSpace(DescriptionTextBox.Text)
                    ? null
                    : DescriptionTextBox.Text.Trim(),
                Status = status
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
