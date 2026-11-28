namespace Prodesk.App
{
    partial class EmployeeForm
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
            label1 = new Label();
            FullNameTextBox = new TextBox();
            label2 = new Label();
            EmailTextBox = new TextBox();
            label3 = new Label();
            PositionTextBox = new TextBox();
            ExperienceYearsNumericUpDown = new NumericUpDown();
            label4 = new Label();
            SaveButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ExperienceYearsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Unispace", 15F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(32, 33);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(155, 24);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Новый сотрудник";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 73);
            label1.Name = "label1";
            label1.Size = new Size(137, 18);
            label1.TabIndex = 3;
            label1.Text = "ФИО Сотрудника";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.BackColor = Color.FromArgb(58, 80, 107);
            FullNameTextBox.BorderStyle = BorderStyle.None;
            FullNameTextBox.Font = new Font("Segoe UI", 10F);
            FullNameTextBox.ForeColor = Color.White;
            FullNameTextBox.Location = new Point(33, 105);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(193, 18);
            FullNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(271, 73);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.FromArgb(58, 80, 107);
            EmailTextBox.BorderStyle = BorderStyle.None;
            EmailTextBox.Font = new Font("Segoe UI", 10F);
            EmailTextBox.ForeColor = Color.White;
            EmailTextBox.Location = new Point(271, 105);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(193, 18);
            EmailTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 147);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 7;
            label3.Text = "Должность";
            // 
            // PositionTextBox
            // 
            PositionTextBox.BackColor = Color.FromArgb(58, 80, 107);
            PositionTextBox.BorderStyle = BorderStyle.None;
            PositionTextBox.Font = new Font("Segoe UI", 10F);
            PositionTextBox.ForeColor = Color.White;
            PositionTextBox.Location = new Point(32, 186);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(193, 18);
            PositionTextBox.TabIndex = 8;
            // 
            // ExperienceYearsNumericUpDown
            // 
            ExperienceYearsNumericUpDown.BackColor = Color.FromArgb(58, 80, 107);
            ExperienceYearsNumericUpDown.ForeColor = Color.White;
            ExperienceYearsNumericUpDown.Location = new Point(271, 186);
            ExperienceYearsNumericUpDown.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            ExperienceYearsNumericUpDown.Name = "ExperienceYearsNumericUpDown";
            ExperienceYearsNumericUpDown.Size = new Size(193, 23);
            ExperienceYearsNumericUpDown.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 13F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(271, 147);
            label4.Name = "label4";
            label4.Size = new Size(106, 18);
            label4.TabIndex = 10;
            label4.Text = "Опыт работы";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(91, 192, 190);
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(384, 277);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(80, 37);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Создать";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(58, 80, 107);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(298, 277);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(80, 37);
            CloseButton.TabIndex = 11;
            CloseButton.Text = "Отмена";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 37, 65);
            ClientSize = new Size(495, 347);
            Controls.Add(SaveButton);
            Controls.Add(CloseButton);
            Controls.Add(label4);
            Controls.Add(ExperienceYearsNumericUpDown);
            Controls.Add(PositionTextBox);
            Controls.Add(label3);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(FullNameTextBox);
            Controls.Add(label1);
            Controls.Add(TitleLabel);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)ExperienceYearsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label label1;
        private TextBox FullNameTextBox;
        private Label label2;
        private TextBox EmailTextBox;
        private Label label3;
        private TextBox PositionTextBox;
        private NumericUpDown ExperienceYearsNumericUpDown;
        private Label label4;
        private Button SaveButton;
        private Button CloseButton;
    }
}