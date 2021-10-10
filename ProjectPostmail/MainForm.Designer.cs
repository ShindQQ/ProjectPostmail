
namespace ProjectPostmail
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PostofficeNumberBox = new System.Windows.Forms.TextBox();
            this.ReceiverIDBox = new System.Windows.Forms.TextBox();
            this.SenderIDBox = new System.Windows.Forms.TextBox();
            this.CreateParcel = new System.Windows.Forms.Button();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SenderCheckBox = new System.Windows.Forms.CheckBox();
            this.ReceiverCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.ReceiverCheckBox);
            this.groupBox1.Controls.Add(this.SenderCheckBox);
            this.groupBox1.Controls.Add(this.PostofficeNumberBox);
            this.groupBox1.Controls.Add(this.ReceiverIDBox);
            this.groupBox1.Controls.Add(this.SenderIDBox);
            this.groupBox1.Controls.Add(this.CreateParcel);
            this.groupBox1.Controls.Add(this.AgeBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.SurnameBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(534, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Відправити посилку";
            // 
            // PostofficeNumberBox
            // 
            this.PostofficeNumberBox.Location = new System.Drawing.Point(6, 201);
            this.PostofficeNumberBox.Name = "PostofficeNumberBox";
            this.PostofficeNumberBox.Size = new System.Drawing.Size(173, 22);
            this.PostofficeNumberBox.TabIndex = 9;
            this.PostofficeNumberBox.Text = "Введіть номер відділення";
            this.PostofficeNumberBox.TextChanged += new System.EventHandler(this.PostofficeNumberBox_TextChanged);
            // 
            // ReceiverIDBox
            // 
            this.ReceiverIDBox.Location = new System.Drawing.Point(6, 173);
            this.ReceiverIDBox.Name = "ReceiverIDBox";
            this.ReceiverIDBox.Size = new System.Drawing.Size(173, 22);
            this.ReceiverIDBox.TabIndex = 8;
            this.ReceiverIDBox.Text = "Введіть ID отримувача";
            this.ReceiverIDBox.TextChanged += new System.EventHandler(this.ReceiverIDBox_TextChanged);
            // 
            // SenderIDBox
            // 
            this.SenderIDBox.Location = new System.Drawing.Point(6, 145);
            this.SenderIDBox.Name = "SenderIDBox";
            this.SenderIDBox.Size = new System.Drawing.Size(173, 22);
            this.SenderIDBox.TabIndex = 7;
            this.SenderIDBox.Text = "Введіть ваш ID";
            this.SenderIDBox.TextChanged += new System.EventHandler(this.SenderIDBox_TextChanged);
            // 
            // CreateParcel
            // 
            this.CreateParcel.AutoSize = true;
            this.CreateParcel.Location = new System.Drawing.Point(6, 28);
            this.CreateParcel.Name = "CreateParcel";
            this.CreateParcel.Size = new System.Drawing.Size(173, 27);
            this.CreateParcel.TabIndex = 6;
            this.CreateParcel.Text = "Створити посилку";
            this.CreateParcel.UseVisualStyleBackColor = true;
            this.CreateParcel.Click += new System.EventHandler(this.CreateParcel_Click);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(6, 61);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(173, 22);
            this.AgeBox.TabIndex = 5;
            this.AgeBox.Text = "Введіть ваш вік";
            this.AgeBox.TextChanged += new System.EventHandler(this.AgeBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 89);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(173, 22);
            this.NameBox.TabIndex = 4;
            this.NameBox.Text = "Введіть ваше ім\'я";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(6, 117);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(173, 22);
            this.SurnameBox.TabIndex = 3;
            this.SurnameBox.Text = "Введіть ваше прізвище";
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
            // 
            // SenderCheckBox
            // 
            this.SenderCheckBox.AutoSize = true;
            this.SenderCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SenderCheckBox.Location = new System.Drawing.Point(6, 229);
            this.SenderCheckBox.Name = "SenderCheckBox";
            this.SenderCheckBox.Size = new System.Drawing.Size(163, 21);
            this.SenderCheckBox.TabIndex = 10;
            this.SenderCheckBox.Text = "Оплачує відправник";
            this.SenderCheckBox.UseVisualStyleBackColor = false;
            this.SenderCheckBox.CheckedChanged += new System.EventHandler(this.SenderCheckBox_CheckedChanged);
            // 
            // ReceiverCheckBox
            // 
            this.ReceiverCheckBox.AutoSize = true;
            this.ReceiverCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReceiverCheckBox.Location = new System.Drawing.Point(6, 256);
            this.ReceiverCheckBox.Name = "ReceiverCheckBox";
            this.ReceiverCheckBox.Size = new System.Drawing.Size(161, 21);
            this.ReceiverCheckBox.TabIndex = 11;
            this.ReceiverCheckBox.Text = "Оплачує отримувач";
            this.ReceiverCheckBox.UseVisualStyleBackColor = false;
            this.ReceiverCheckBox.CheckedChanged += new System.EventHandler(this.ReceiverCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProjectPostmail.Properties.Resources.banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Button CreateParcel;
        private System.Windows.Forms.TextBox PostofficeNumberBox;
        private System.Windows.Forms.TextBox ReceiverIDBox;
        private System.Windows.Forms.TextBox SenderIDBox;
        private System.Windows.Forms.CheckBox ReceiverCheckBox;
        private System.Windows.Forms.CheckBox SenderCheckBox;
    }
}

