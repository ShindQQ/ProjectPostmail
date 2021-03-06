
namespace ProjectPostmail
{
    partial class AdministrationForm
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
            this.PostofficeTab = new System.Windows.Forms.TabControl();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.DepartmentEmployerGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployerData = new System.Windows.Forms.DateTimePicker();
            this.EmployerInfo = new System.Windows.Forms.Label();
            this.EmployerGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployerSurnameBox = new System.Windows.Forms.TextBox();
            this.EmployerNameBox = new System.Windows.Forms.TextBox();
            this.EmployerIDBox = new System.Windows.Forms.TextBox();
            this.EmployerButton = new System.Windows.Forms.Button();
            this.EmployerDepartmentBox = new System.Windows.Forms.TextBox();
            this.EmployerTab = new System.Windows.Forms.TabPage();
            this.DepartmentEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeData = new System.Windows.Forms.DateTimePicker();
            this.EmployeeInfo = new System.Windows.Forms.Label();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeSurnameBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDBox = new System.Windows.Forms.TextBox();
            this.EmployeeDepartmentBox = new System.Windows.Forms.TextBox();
            this.FormAccess = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.GroupBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PostofficeTab.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.DepartmentEmployerGroupBox.SuspendLayout();
            this.EmployerGroupBox.SuspendLayout();
            this.EmployerTab.SuspendLayout();
            this.DepartmentEmployeeGroupBox.SuspendLayout();
            this.EmployeeGroupBox.SuspendLayout();
            this.PasswordBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PostofficeTab
            // 
            this.PostofficeTab.Controls.Add(this.EmployeeTab);
            this.PostofficeTab.Controls.Add(this.EmployerTab);
            this.PostofficeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostofficeTab.Location = new System.Drawing.Point(0, 0);
            this.PostofficeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PostofficeTab.Name = "PostofficeTab";
            this.PostofficeTab.SelectedIndex = 0;
            this.PostofficeTab.Size = new System.Drawing.Size(900, 562);
            this.PostofficeTab.TabIndex = 5;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.DepartmentEmployerGroupBox);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 29);
            this.EmployeeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeTab.Size = new System.Drawing.Size(892, 529);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "Роботодавець";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            // 
            // DepartmentEmployerGroupBox
            // 
            this.DepartmentEmployerGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepartmentEmployerGroupBox.Controls.Add(this.EmployerData);
            this.DepartmentEmployerGroupBox.Controls.Add(this.EmployerInfo);
            this.DepartmentEmployerGroupBox.Controls.Add(this.EmployerGroupBox);
            this.DepartmentEmployerGroupBox.Controls.Add(this.EmployerButton);
            this.DepartmentEmployerGroupBox.Controls.Add(this.EmployerDepartmentBox);
            this.DepartmentEmployerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentEmployerGroupBox.Location = new System.Drawing.Point(3, 4);
            this.DepartmentEmployerGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentEmployerGroupBox.Name = "DepartmentEmployerGroupBox";
            this.DepartmentEmployerGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentEmployerGroupBox.Size = new System.Drawing.Size(886, 521);
            this.DepartmentEmployerGroupBox.TabIndex = 4;
            this.DepartmentEmployerGroupBox.TabStop = false;
            this.DepartmentEmployerGroupBox.Text = "Відділення № ";
            this.DepartmentEmployerGroupBox.Enter += new System.EventHandler(this.DepartmentEmployerGroupBox_Enter);
            // 
            // EmployerData
            // 
            this.EmployerData.Location = new System.Drawing.Point(3, 58);
            this.EmployerData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerData.Name = "EmployerData";
            this.EmployerData.Size = new System.Drawing.Size(196, 26);
            this.EmployerData.TabIndex = 22;
            this.EmployerData.ValueChanged += new System.EventHandler(this.EmployerData_ValueChanged);
            // 
            // EmployerInfo
            // 
            this.EmployerInfo.BackColor = System.Drawing.Color.Transparent;
            this.EmployerInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployerInfo.Location = new System.Drawing.Point(247, 23);
            this.EmployerInfo.Name = "EmployerInfo";
            this.EmployerInfo.Size = new System.Drawing.Size(636, 494);
            this.EmployerInfo.TabIndex = 19;
            this.EmployerInfo.Text = "Інформація про Вас:";
            this.EmployerInfo.Click += new System.EventHandler(this.EmployerInfo_Click);
            // 
            // EmployerGroupBox
            // 
            this.EmployerGroupBox.Controls.Add(this.EmployerSurnameBox);
            this.EmployerGroupBox.Controls.Add(this.EmployerNameBox);
            this.EmployerGroupBox.Controls.Add(this.EmployerIDBox);
            this.EmployerGroupBox.Location = new System.Drawing.Point(3, 92);
            this.EmployerGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerGroupBox.Name = "EmployerGroupBox";
            this.EmployerGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerGroupBox.Size = new System.Drawing.Size(217, 134);
            this.EmployerGroupBox.TabIndex = 15;
            this.EmployerGroupBox.TabStop = false;
            this.EmployerGroupBox.Text = "Заповніть особисті дані";
            this.EmployerGroupBox.Enter += new System.EventHandler(this.EmployerGroupBox_Enter);
            // 
            // EmployerSurnameBox
            // 
            this.EmployerSurnameBox.Location = new System.Drawing.Point(7, 58);
            this.EmployerSurnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerSurnameBox.Name = "EmployerSurnameBox";
            this.EmployerSurnameBox.Size = new System.Drawing.Size(194, 26);
            this.EmployerSurnameBox.TabIndex = 10;
            this.EmployerSurnameBox.Text = "Введіть ваше прізвище";
            this.EmployerSurnameBox.TextChanged += new System.EventHandler(this.EmployerSurnameBox_TextChanged);
            // 
            // EmployerNameBox
            // 
            this.EmployerNameBox.Location = new System.Drawing.Point(7, 22);
            this.EmployerNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerNameBox.Name = "EmployerNameBox";
            this.EmployerNameBox.Size = new System.Drawing.Size(194, 26);
            this.EmployerNameBox.TabIndex = 11;
            this.EmployerNameBox.Text = "Введіть ваше ім\'я";
            this.EmployerNameBox.TextChanged += new System.EventHandler(this.EmployerNameBox_TextChanged);
            // 
            // EmployerIDBox
            // 
            this.EmployerIDBox.Location = new System.Drawing.Point(7, 92);
            this.EmployerIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerIDBox.Name = "EmployerIDBox";
            this.EmployerIDBox.Size = new System.Drawing.Size(194, 26);
            this.EmployerIDBox.TabIndex = 12;
            this.EmployerIDBox.Text = "Введіть ваш ID";
            this.EmployerIDBox.TextChanged += new System.EventHandler(this.EmployerIDBox_TextChanged);
            // 
            // EmployerButton
            // 
            this.EmployerButton.AutoSize = true;
            this.EmployerButton.Location = new System.Drawing.Point(3, 234);
            this.EmployerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerButton.Name = "EmployerButton";
            this.EmployerButton.Size = new System.Drawing.Size(198, 38);
            this.EmployerButton.TabIndex = 14;
            this.EmployerButton.Text = "Вивести інформацію";
            this.EmployerButton.UseVisualStyleBackColor = true;
            this.EmployerButton.Click += new System.EventHandler(this.EmployerButton_Click);
            // 
            // EmployerDepartmentBox
            // 
            this.EmployerDepartmentBox.Location = new System.Drawing.Point(3, 22);
            this.EmployerDepartmentBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerDepartmentBox.Name = "EmployerDepartmentBox";
            this.EmployerDepartmentBox.Size = new System.Drawing.Size(196, 26);
            this.EmployerDepartmentBox.TabIndex = 0;
            this.EmployerDepartmentBox.Text = "Введіть номер відділення";
            this.EmployerDepartmentBox.TextChanged += new System.EventHandler(this.EmployerDepartmentBox_TextChanged);
            // 
            // EmployerTab
            // 
            this.EmployerTab.Controls.Add(this.DepartmentEmployeeGroupBox);
            this.EmployerTab.Location = new System.Drawing.Point(4, 29);
            this.EmployerTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerTab.Name = "EmployerTab";
            this.EmployerTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployerTab.Size = new System.Drawing.Size(892, 529);
            this.EmployerTab.TabIndex = 1;
            this.EmployerTab.Text = "Працівник";
            this.EmployerTab.UseVisualStyleBackColor = true;
            // 
            // DepartmentEmployeeGroupBox
            // 
            this.DepartmentEmployeeGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepartmentEmployeeGroupBox.Controls.Add(this.EmployeeData);
            this.DepartmentEmployeeGroupBox.Controls.Add(this.EmployeeInfo);
            this.DepartmentEmployeeGroupBox.Controls.Add(this.EmployeeButton);
            this.DepartmentEmployeeGroupBox.Controls.Add(this.EmployeeGroupBox);
            this.DepartmentEmployeeGroupBox.Controls.Add(this.EmployeeDepartmentBox);
            this.DepartmentEmployeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentEmployeeGroupBox.Location = new System.Drawing.Point(3, 4);
            this.DepartmentEmployeeGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentEmployeeGroupBox.Name = "DepartmentEmployeeGroupBox";
            this.DepartmentEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentEmployeeGroupBox.Size = new System.Drawing.Size(886, 521);
            this.DepartmentEmployeeGroupBox.TabIndex = 5;
            this.DepartmentEmployeeGroupBox.TabStop = false;
            this.DepartmentEmployeeGroupBox.Text = "Відділення № ";
            this.DepartmentEmployeeGroupBox.Enter += new System.EventHandler(this.DepartmentEmployeeGroupBox_Enter);
            // 
            // EmployeeData
            // 
            this.EmployeeData.Location = new System.Drawing.Point(3, 58);
            this.EmployeeData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.Size = new System.Drawing.Size(196, 26);
            this.EmployeeData.TabIndex = 21;
            this.EmployeeData.ValueChanged += new System.EventHandler(this.EmployeeData_ValueChanged);
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployeeInfo.Location = new System.Drawing.Point(244, 23);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(639, 494);
            this.EmployeeInfo.TabIndex = 20;
            this.EmployeeInfo.Text = "Інформація про Вас:";
            this.EmployeeInfo.Click += new System.EventHandler(this.EmployeeInfo_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.AutoSize = true;
            this.EmployeeButton.Location = new System.Drawing.Point(3, 234);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(198, 38);
            this.EmployeeButton.TabIndex = 17;
            this.EmployeeButton.Text = "Вивести інформацію";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.EmployeeSurnameBox);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeNameBox);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeIDBox);
            this.EmployeeGroupBox.Location = new System.Drawing.Point(3, 92);
            this.EmployeeGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeGroupBox.Size = new System.Drawing.Size(217, 134);
            this.EmployeeGroupBox.TabIndex = 16;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Заповніть особисті дані";
            this.EmployeeGroupBox.Enter += new System.EventHandler(this.EmployeeGroupBox_Enter);
            // 
            // EmployeeSurnameBox
            // 
            this.EmployeeSurnameBox.Location = new System.Drawing.Point(7, 58);
            this.EmployeeSurnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeSurnameBox.Name = "EmployeeSurnameBox";
            this.EmployeeSurnameBox.Size = new System.Drawing.Size(194, 26);
            this.EmployeeSurnameBox.TabIndex = 10;
            this.EmployeeSurnameBox.Text = "Введіть ваше прізвище";
            this.EmployeeSurnameBox.TextChanged += new System.EventHandler(this.EmployeeSurnameBox_TextChanged);
            // 
            // EmployeeNameBox
            // 
            this.EmployeeNameBox.Location = new System.Drawing.Point(7, 22);
            this.EmployeeNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeNameBox.Name = "EmployeeNameBox";
            this.EmployeeNameBox.Size = new System.Drawing.Size(194, 26);
            this.EmployeeNameBox.TabIndex = 11;
            this.EmployeeNameBox.Text = "Введіть ваше ім\'я";
            this.EmployeeNameBox.TextChanged += new System.EventHandler(this.EmployeeNameBox_TextChanged);
            // 
            // EmployeeIDBox
            // 
            this.EmployeeIDBox.Location = new System.Drawing.Point(7, 92);
            this.EmployeeIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeIDBox.Name = "EmployeeIDBox";
            this.EmployeeIDBox.Size = new System.Drawing.Size(194, 26);
            this.EmployeeIDBox.TabIndex = 12;
            this.EmployeeIDBox.Text = "Введіть ваш ID";
            this.EmployeeIDBox.TextChanged += new System.EventHandler(this.EmployeeIDBox_TextChanged);
            // 
            // EmployeeDepartmentBox
            // 
            this.EmployeeDepartmentBox.Location = new System.Drawing.Point(3, 22);
            this.EmployeeDepartmentBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeDepartmentBox.Name = "EmployeeDepartmentBox";
            this.EmployeeDepartmentBox.Size = new System.Drawing.Size(196, 26);
            this.EmployeeDepartmentBox.TabIndex = 0;
            this.EmployeeDepartmentBox.Text = "Введіть номер відділення";
            this.EmployeeDepartmentBox.TextChanged += new System.EventHandler(this.EmployeeDepartmentBox_TextChanged);
            // 
            // FormAccess
            // 
            this.FormAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormAccess.Location = new System.Drawing.Point(0, 0);
            this.FormAccess.Name = "FormAccess";
            this.FormAccess.Size = new System.Drawing.Size(900, 562);
            this.FormAccess.TabIndex = 6;
            this.FormAccess.Text = "   ";
            this.FormAccess.Click += new System.EventHandler(this.FormAccess_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordBox.Controls.Add(this.PasswordTextBox);
            this.PasswordBox.Location = new System.Drawing.Point(338, 219);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordBox.Size = new System.Drawing.Size(225, 125);
            this.PasswordBox.TabIndex = 7;
            this.PasswordBox.TabStop = false;
            this.PasswordBox.Text = "Введіть пароль";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(50, 49);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(127, 26);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyUp);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPostmail.Properties.Resources.banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.FormAccess);
            this.Controls.Add(this.PostofficeTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.PostofficeTab.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.DepartmentEmployerGroupBox.ResumeLayout(false);
            this.DepartmentEmployerGroupBox.PerformLayout();
            this.EmployerGroupBox.ResumeLayout(false);
            this.EmployerGroupBox.PerformLayout();
            this.EmployerTab.ResumeLayout(false);
            this.DepartmentEmployeeGroupBox.ResumeLayout(false);
            this.DepartmentEmployeeGroupBox.PerformLayout();
            this.EmployeeGroupBox.ResumeLayout(false);
            this.EmployeeGroupBox.PerformLayout();
            this.PasswordBox.ResumeLayout(false);
            this.PasswordBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl PostofficeTab;
        private System.Windows.Forms.TabPage EmployeeTab;
        private System.Windows.Forms.GroupBox DepartmentEmployerGroupBox;
        private System.Windows.Forms.TextBox EmployerDepartmentBox;
        private System.Windows.Forms.TabPage EmployerTab;
        private System.Windows.Forms.GroupBox DepartmentEmployeeGroupBox;
        private System.Windows.Forms.TextBox EmployeeDepartmentBox;
        private System.Windows.Forms.TextBox EmployerIDBox;
        private System.Windows.Forms.TextBox EmployerNameBox;
        private System.Windows.Forms.TextBox EmployerSurnameBox;
        private System.Windows.Forms.GroupBox EmployerGroupBox;
        private System.Windows.Forms.Button EmployerButton;
        private System.Windows.Forms.Label EmployerInfo;
        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.TextBox EmployeeSurnameBox;
        private System.Windows.Forms.TextBox EmployeeNameBox;
        private System.Windows.Forms.TextBox EmployeeIDBox;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Label EmployeeInfo;
        private System.Windows.Forms.DateTimePicker EmployerData;
        private System.Windows.Forms.DateTimePicker EmployeeData;
        private System.Windows.Forms.Label FormAccess;
        private System.Windows.Forms.GroupBox PasswordBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}