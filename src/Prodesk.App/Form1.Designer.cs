namespace Prodesk.App;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        SidebarPanel = new Panel();
        label3 = new Label();
        label2 = new Label();
        button2 = new Button();
        SelectionButton = new Button();
        EmployeesButton = new Button();
        label1 = new Label();
        TitleLabel = new Label();
        ContentPanel = new Panel();
        WorkspacePanel = new Panel();
        ProjectsGridView = new DataGridView();
        ProjectsToolbarPanel = new Panel();
        DeleteProjectButton = new Button();
        EditProjectButton = new Button();
        AddProjectButton = new Button();
        ProjectsSectionLabel = new Label();
        HeaderPanel = new Panel();
        ProjectsLabel = new Label();
        SidebarPanel.SuspendLayout();
        ContentPanel.SuspendLayout();
        WorkspacePanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ProjectsGridView).BeginInit();
        ProjectsToolbarPanel.SuspendLayout();
        HeaderPanel.SuspendLayout();
        SuspendLayout();
        // 
        // SidebarPanel
        // 
        SidebarPanel.Controls.Add(label3);
        SidebarPanel.Controls.Add(label2);
        SidebarPanel.Controls.Add(button2);
        SidebarPanel.Controls.Add(SelectionButton);
        SidebarPanel.Controls.Add(EmployeesButton);
        SidebarPanel.Controls.Add(label1);
        SidebarPanel.Controls.Add(TitleLabel);
        SidebarPanel.Dock = DockStyle.Left;
        SidebarPanel.Location = new Point(0, 0);
        SidebarPanel.Name = "SidebarPanel";
        SidebarPanel.Size = new Size(230, 711);
        SidebarPanel.TabIndex = 0;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.FromArgb(58, 80, 107);
        label3.Location = new Point(34, 664);
        label3.Name = "label3";
        label3.Size = new Size(148, 19);
        label3.TabIndex = 6;
        label3.Text = "Все права защищены.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.FromArgb(58, 80, 107);
        label2.Location = new Point(34, 645);
        label2.Name = "label2";
        label2.Size = new Size(117, 19);
        label2.TabIndex = 5;
        label2.Text = "© Кочкин Семен";
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(91, 192, 190);
        button2.Cursor = Cursors.Hand;
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
        button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Unispace", 15F, FontStyle.Bold);
        button2.ForeColor = Color.White;
        button2.Location = new Point(57, 276);
        button2.Name = "button2";
        button2.Size = new Size(118, 33);
        button2.TabIndex = 4;
        button2.Text = "Проекты";
        button2.UseVisualStyleBackColor = false;
        // 
        // SelectionButton
        // 
        SelectionButton.BackColor = Color.FromArgb(91, 192, 190);
        SelectionButton.Cursor = Cursors.Hand;
        SelectionButton.FlatAppearance.BorderSize = 0;
        SelectionButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
        SelectionButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
        SelectionButton.FlatStyle = FlatStyle.Flat;
        SelectionButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
        SelectionButton.ForeColor = Color.White;
        SelectionButton.Location = new Point(57, 382);
        SelectionButton.Name = "SelectionButton";
        SelectionButton.Size = new Size(118, 33);
        SelectionButton.TabIndex = 3;
        SelectionButton.Text = "Подбор";
        SelectionButton.UseVisualStyleBackColor = false;
        // 
        // EmployeesButton
        // 
        EmployeesButton.BackColor = Color.FromArgb(91, 192, 190);
        EmployeesButton.Cursor = Cursors.Hand;
        EmployeesButton.FlatAppearance.BorderSize = 0;
        EmployeesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
        EmployeesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
        EmployeesButton.FlatStyle = FlatStyle.Flat;
        EmployeesButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
        EmployeesButton.ForeColor = Color.White;
        EmployeesButton.Location = new Point(57, 328);
        EmployeesButton.Name = "EmployeesButton";
        EmployeesButton.Size = new Size(118, 33);
        EmployeesButton.TabIndex = 2;
        EmployeesButton.Text = "Сотрудники";
        EmployeesButton.UseVisualStyleBackColor = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.White;
        label1.Location = new Point(34, 78);
        label1.Name = "label1";
        label1.Size = new Size(129, 19);
        label1.TabIndex = 1;
        label1.Text = "Подбор персонала";
        // 
        // TitleLabel
        // 
        TitleLabel.AutoSize = true;
        TitleLabel.BackColor = Color.Transparent;
        TitleLabel.Font = new Font("Unispace", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        TitleLabel.ForeColor = Color.White;
        TitleLabel.Location = new Point(29, 38);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new Size(157, 40);
        TitleLabel.TabIndex = 0;
        TitleLabel.Text = "Prodesk";
        // 
        // ContentPanel
        // 
        ContentPanel.BackColor = Color.FromArgb(28, 37, 65);
        ContentPanel.Controls.Add(WorkspacePanel);
        ContentPanel.Controls.Add(HeaderPanel);
        ContentPanel.Dock = DockStyle.Fill;
        ContentPanel.Location = new Point(230, 0);
        ContentPanel.Name = "ContentPanel";
        ContentPanel.Size = new Size(954, 711);
        ContentPanel.TabIndex = 1;
        // 
        // WorkspacePanel
        // 
        WorkspacePanel.Controls.Add(ProjectsGridView);
        WorkspacePanel.Controls.Add(ProjectsToolbarPanel);
        WorkspacePanel.Dock = DockStyle.Fill;
        WorkspacePanel.Location = new Point(0, 56);
        WorkspacePanel.Name = "WorkspacePanel";
        WorkspacePanel.Padding = new Padding(20);
        WorkspacePanel.Size = new Size(954, 655);
        WorkspacePanel.TabIndex = 1;
        // 
        // ProjectsGridView
        // 
        ProjectsGridView.AllowUserToAddRows = false;
        ProjectsGridView.AllowUserToDeleteRows = false;
        ProjectsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        ProjectsGridView.BackgroundColor = Color.FromArgb(28, 37, 65);
        ProjectsGridView.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 80, 107);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle1.ForeColor = Color.White;
        dataGridViewCellStyle1.Padding = new Padding(10, 5, 10, 5);
        dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        ProjectsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        ProjectsGridView.ColumnHeadersHeight = 55;
        ProjectsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 37, 65);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.Padding = new Padding(10, 5, 10, 5);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 80, 107);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(91, 192, 190);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        ProjectsGridView.DefaultCellStyle = dataGridViewCellStyle2;
        ProjectsGridView.Dock = DockStyle.Fill;
        ProjectsGridView.EnableHeadersVisualStyles = false;
        ProjectsGridView.GridColor = Color.FromArgb(58, 80, 107);
        ProjectsGridView.Location = new Point(20, 80);
        ProjectsGridView.MultiSelect = false;
        ProjectsGridView.Name = "ProjectsGridView";
        ProjectsGridView.ReadOnly = true;
        ProjectsGridView.RowHeadersVisible = false;
        ProjectsGridView.RowTemplate.Height = 55;
        ProjectsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ProjectsGridView.Size = new Size(914, 555);
        ProjectsGridView.TabIndex = 1;
        ProjectsGridView.SelectionChanged += ProjectsGridView_SelectionChanged;
        // 
        // ProjectsToolbarPanel
        // 
        ProjectsToolbarPanel.Controls.Add(DeleteProjectButton);
        ProjectsToolbarPanel.Controls.Add(EditProjectButton);
        ProjectsToolbarPanel.Controls.Add(AddProjectButton);
        ProjectsToolbarPanel.Controls.Add(ProjectsSectionLabel);
        ProjectsToolbarPanel.Dock = DockStyle.Top;
        ProjectsToolbarPanel.Location = new Point(20, 20);
        ProjectsToolbarPanel.Name = "ProjectsToolbarPanel";
        ProjectsToolbarPanel.Padding = new Padding(0, 0, 0, 10);
        ProjectsToolbarPanel.Size = new Size(914, 60);
        ProjectsToolbarPanel.TabIndex = 0;
        // 
        // DeleteProjectButton
        // 
        DeleteProjectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        DeleteProjectButton.BackColor = Color.FromArgb(58, 80, 107);
        DeleteProjectButton.Cursor = Cursors.Hand;
        DeleteProjectButton.Enabled = false;
        DeleteProjectButton.FlatAppearance.BorderSize = 0;
        DeleteProjectButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
        DeleteProjectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
        DeleteProjectButton.FlatStyle = FlatStyle.Flat;
        DeleteProjectButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
        DeleteProjectButton.ForeColor = Color.White;
        DeleteProjectButton.Location = new Point(570, 15);
        DeleteProjectButton.Name = "DeleteProjectButton";
        DeleteProjectButton.Size = new Size(147, 31);
        DeleteProjectButton.TabIndex = 7;
        DeleteProjectButton.Text = "Удалить";
        DeleteProjectButton.UseVisualStyleBackColor = false;
        DeleteProjectButton.Click += DeleteProjectButton_Click;
        // 
        // EditProjectButton
        // 
        EditProjectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        EditProjectButton.BackColor = Color.FromArgb(58, 80, 107);
        EditProjectButton.Cursor = Cursors.Hand;
        EditProjectButton.Enabled = false;
        EditProjectButton.FlatAppearance.BorderSize = 0;
        EditProjectButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
        EditProjectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
        EditProjectButton.FlatStyle = FlatStyle.Flat;
        EditProjectButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
        EditProjectButton.ForeColor = Color.White;
        EditProjectButton.Location = new Point(417, 15);
        EditProjectButton.Name = "EditProjectButton";
        EditProjectButton.Size = new Size(147, 31);
        EditProjectButton.TabIndex = 6;
        EditProjectButton.Text = "Редактировать";
        EditProjectButton.UseVisualStyleBackColor = false;
        EditProjectButton.Click += EditProjectButton_Click;
        // 
        // AddProjectButton
        // 
        AddProjectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        AddProjectButton.BackColor = Color.FromArgb(91, 192, 190);
        AddProjectButton.Cursor = Cursors.Hand;
        AddProjectButton.FlatAppearance.BorderSize = 0;
        AddProjectButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 59, 85);
        AddProjectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 80, 107);
        AddProjectButton.FlatStyle = FlatStyle.Flat;
        AddProjectButton.Font = new Font("Unispace", 15F, FontStyle.Bold);
        AddProjectButton.ForeColor = Color.White;
        AddProjectButton.Location = new Point(723, 15);
        AddProjectButton.Name = "AddProjectButton";
        AddProjectButton.Size = new Size(188, 31);
        AddProjectButton.TabIndex = 5;
        AddProjectButton.Text = "Добавить проект";
        AddProjectButton.UseVisualStyleBackColor = false;
        AddProjectButton.Click += AddProjectButton_Click;
        // 
        // ProjectsSectionLabel
        // 
        ProjectsSectionLabel.AutoSize = true;
        ProjectsSectionLabel.Font = new Font("Unispace", 15F, FontStyle.Bold);
        ProjectsSectionLabel.ForeColor = Color.White;
        ProjectsSectionLabel.Location = new Point(0, 18);
        ProjectsSectionLabel.Name = "ProjectsSectionLabel";
        ProjectsSectionLabel.Size = new Size(117, 24);
        ProjectsSectionLabel.TabIndex = 0;
        ProjectsSectionLabel.Text = "Все проекты";
        // 
        // HeaderPanel
        // 
        HeaderPanel.BorderStyle = BorderStyle.FixedSingle;
        HeaderPanel.Controls.Add(ProjectsLabel);
        HeaderPanel.Dock = DockStyle.Top;
        HeaderPanel.Location = new Point(0, 0);
        HeaderPanel.Name = "HeaderPanel";
        HeaderPanel.Size = new Size(954, 56);
        HeaderPanel.TabIndex = 0;
        // 
        // ProjectsLabel
        // 
        ProjectsLabel.AutoSize = true;
        ProjectsLabel.Font = new Font("Unispace", 15F, FontStyle.Bold);
        ProjectsLabel.ForeColor = Color.White;
        ProjectsLabel.Location = new Point(15, 14);
        ProjectsLabel.Name = "ProjectsLabel";
        ProjectsLabel.Size = new Size(79, 24);
        ProjectsLabel.TabIndex = 0;
        ProjectsLabel.Text = "Проекты";
        ProjectsLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(11, 19, 43);
        ClientSize = new Size(1184, 711);
        Controls.Add(ContentPanel);
        Controls.Add(SidebarPanel);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(1000, 650);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Prodesk (Курсовая работа Кочкин Семен ИТ2601)";
        SidebarPanel.ResumeLayout(false);
        SidebarPanel.PerformLayout();
        ContentPanel.ResumeLayout(false);
        WorkspacePanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)ProjectsGridView).EndInit();
        ProjectsToolbarPanel.ResumeLayout(false);
        ProjectsToolbarPanel.PerformLayout();
        HeaderPanel.ResumeLayout(false);
        HeaderPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel SidebarPanel;
    private Label TitleLabel;
    private Panel ContentPanel;
    private Label label1;
    private Button EmployeesButton;
    private Button button2;
    private Button SelectionButton;
    private Label label3;
    private Label label2;
    private Panel HeaderPanel;
    private Label ProjectsLabel;
    private Panel WorkspacePanel;
    private Panel ProjectsToolbarPanel;
    private Label ProjectsSectionLabel;
    private Button AddProjectButton;
    private DataGridView ProjectsGridView;
    private Button DeleteProjectButton;
    private Button EditProjectButton;
}
