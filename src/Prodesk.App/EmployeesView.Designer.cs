namespace Prodesk.App
{
    partial class EmployeesView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            EmployeesToolbarPanel = new Panel();
            DeleteEmployeeButton = new Button();
            EditEmployeeButton = new Button();
            AddEmployeeButton = new Button();
            EmployeesSectionLabel = new Label();
            EmployeesGridView = new DataGridView();
            EmployeesToolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesGridView).BeginInit();
            SuspendLayout();
            // 
            // EmployeesToolbarPanel
            // 
            EmployeesToolbarPanel.Controls.Add(DeleteEmployeeButton);
            EmployeesToolbarPanel.Controls.Add(EditEmployeeButton);
            EmployeesToolbarPanel.Controls.Add(AddEmployeeButton);
            EmployeesToolbarPanel.Controls.Add(EmployeesSectionLabel);
            EmployeesToolbarPanel.Dock = DockStyle.Top;
            EmployeesToolbarPanel.Location = new Point(0, 0);
            EmployeesToolbarPanel.Name = "EmployeesToolbarPanel";
            EmployeesToolbarPanel.Size = new Size(900, 55);
            EmployeesToolbarPanel.TabIndex = 0;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteEmployeeButton.BackColor = Color.FromArgb(58, 80, 107);
            DeleteEmployeeButton.Cursor = Cursors.Hand;
            DeleteEmployeeButton.Enabled = false;
            DeleteEmployeeButton.FlatAppearance.BorderSize = 0;
            DeleteEmployeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
            DeleteEmployeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
            DeleteEmployeeButton.FlatStyle = FlatStyle.Flat;
            DeleteEmployeeButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
            DeleteEmployeeButton.ForeColor = Color.White;
            DeleteEmployeeButton.Location = new Point(556, 11);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(147, 31);
            DeleteEmployeeButton.TabIndex = 10;
            DeleteEmployeeButton.Text = "Удалить";
            DeleteEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // EditEmployeeButton
            // 
            EditEmployeeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditEmployeeButton.BackColor = Color.FromArgb(58, 80, 107);
            EditEmployeeButton.Cursor = Cursors.Hand;
            EditEmployeeButton.Enabled = false;
            EditEmployeeButton.FlatAppearance.BorderSize = 0;
            EditEmployeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
            EditEmployeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
            EditEmployeeButton.FlatStyle = FlatStyle.Flat;
            EditEmployeeButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
            EditEmployeeButton.ForeColor = Color.White;
            EditEmployeeButton.Location = new Point(403, 11);
            EditEmployeeButton.Name = "EditEmployeeButton";
            EditEmployeeButton.Size = new Size(147, 31);
            EditEmployeeButton.TabIndex = 9;
            EditEmployeeButton.Text = "Редактировать";
            EditEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddEmployeeButton.BackColor = Color.FromArgb(91, 192, 190);
            AddEmployeeButton.Cursor = Cursors.Hand;
            AddEmployeeButton.FlatAppearance.BorderSize = 0;
            AddEmployeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
            AddEmployeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
            AddEmployeeButton.FlatStyle = FlatStyle.Flat;
            AddEmployeeButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
            AddEmployeeButton.ForeColor = Color.White;
            AddEmployeeButton.Location = new Point(709, 11);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(188, 31);
            AddEmployeeButton.TabIndex = 8;
            AddEmployeeButton.Text = "Добавить сотрудника";
            AddEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // EmployeesSectionLabel
            // 
            EmployeesSectionLabel.AutoSize = true;
            EmployeesSectionLabel.Font = new Font("Unispace", 15F, FontStyle.Bold);
            EmployeesSectionLabel.ForeColor = Color.White;
            EmployeesSectionLabel.Location = new Point(3, 14);
            EmployeesSectionLabel.Name = "EmployeesSectionLabel";
            EmployeesSectionLabel.Size = new Size(141, 24);
            EmployeesSectionLabel.TabIndex = 1;
            EmployeesSectionLabel.Text = "Все сотрудники";
            // 
            // EmployeesGridView
            // 
            EmployeesGridView.AllowUserToAddRows = false;
            EmployeesGridView.AllowUserToDeleteRows = false;
            EmployeesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesGridView.BackgroundColor = Color.FromArgb(28, 37, 65);
            EmployeesGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 80, 107);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmployeesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmployeesGridView.ColumnHeadersHeight = 55;
            EmployeesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 37, 65);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 80, 107);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(91, 192, 190);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeesGridView.Dock = DockStyle.Fill;
            EmployeesGridView.EnableHeadersVisualStyles = false;
            EmployeesGridView.GridColor = Color.FromArgb(58, 80, 107);
            EmployeesGridView.Location = new Point(0, 55);
            EmployeesGridView.MultiSelect = false;
            EmployeesGridView.Name = "EmployeesGridView";
            EmployeesGridView.ReadOnly = true;
            EmployeesGridView.RowHeadersVisible = false;
            EmployeesGridView.RowTemplate.Height = 55;
            EmployeesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeesGridView.Size = new Size(900, 545);
            EmployeesGridView.TabIndex = 2;
            // 
            // EmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 37, 65);
            Controls.Add(EmployeesGridView);
            Controls.Add(EmployeesToolbarPanel);
            Name = "EmployeesView";
            Size = new Size(900, 600);
            EmployeesToolbarPanel.ResumeLayout(false);
            EmployeesToolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel EmployeesToolbarPanel;
        private Label EmployeesSectionLabel;
        private Button DeleteEmployeeButton;
        private Button EditEmployeeButton;
        private Button AddEmployeeButton;
        private DataGridView EmployeesGridView;
    }
}
