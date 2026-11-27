namespace Prodesk.App
{
    partial class AddProjectForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DescriptionTextBox = new TextBox();
            label3 = new Label();
            StatusComboBox = new ComboBox();
            CancelButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Unispace", 15F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(32, 33);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(128, 24);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Новый проект";
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = Color.FromArgb(58, 80, 107);
            TitleTextBox.BorderStyle = BorderStyle.None;
            TitleTextBox.Font = new Font("Segoe UI", 10F);
            TitleTextBox.ForeColor = Color.White;
            TitleTextBox.Location = new Point(35, 99);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(193, 18);
            TitleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 73);
            label1.Name = "label1";
            label1.Size = new Size(149, 18);
            label1.TabIndex = 2;
            label1.Text = "Название проекта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 146);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 3;
            label2.Text = "Описание";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.FromArgb(58, 80, 107);
            DescriptionTextBox.BorderStyle = BorderStyle.None;
            DescriptionTextBox.Font = new Font("Segoe UI", 10F);
            DescriptionTextBox.ForeColor = Color.White;
            DescriptionTextBox.Location = new Point(35, 178);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(416, 101);
            DescriptionTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 304);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 5;
            label3.Text = "Статус";
            // 
            // StatusComboBox
            // 
            StatusComboBox.BackColor = Color.FromArgb(58, 80, 107);
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(35, 332);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(135, 23);
            StatusComboBox.TabIndex = 6;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(58, 80, 107);
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(290, 324);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(80, 37);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(91, 192, 190);
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(376, 324);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(80, 37);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Создать";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 37, 65);
            ClientSize = new Size(484, 391);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(StatusComboBox);
            Controls.Add(label3);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProjectForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Новый проект";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label label1;
        private Label label2;
        private TextBox DescriptionTextBox;
        private Label label3;
        private ComboBox StatusComboBox;
        private Button CancelButton;
        private Button SaveButton;
    }
}