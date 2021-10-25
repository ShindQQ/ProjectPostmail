
namespace ProjectPostmail
{
    partial class SenderReceiverForm
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
            this.SendParcelBox = new System.Windows.Forms.GroupBox();
            this.AgeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ParcelCapacity = new System.Windows.Forms.TextBox();
            this.PostOfficeReceiverName = new System.Windows.Forms.TextBox();
            this.PostofficeNumberReceiverBox = new System.Windows.Forms.TextBox();
            this.PostOfficeSenderName = new System.Windows.Forms.TextBox();
            this.TextSendLabel = new System.Windows.Forms.Label();
            this.ReceiverCheckBox = new System.Windows.Forms.CheckBox();
            this.SenderCheckBox = new System.Windows.Forms.CheckBox();
            this.PostofficeNumberSenderBox = new System.Windows.Forms.TextBox();
            this.ReceiverIDBox = new System.Windows.Forms.TextBox();
            this.SenderIDBox = new System.Windows.Forms.TextBox();
            this.CreateParcel = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.ParcelInfo = new System.Windows.Forms.Label();
            this.SendParcelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendParcelBox
            // 
            this.SendParcelBox.BackColor = System.Drawing.SystemColors.Menu;
            this.SendParcelBox.Controls.Add(this.AgeTimePicker);
            this.SendParcelBox.Controls.Add(this.ParcelCapacity);
            this.SendParcelBox.Controls.Add(this.PostOfficeReceiverName);
            this.SendParcelBox.Controls.Add(this.PostofficeNumberReceiverBox);
            this.SendParcelBox.Controls.Add(this.PostOfficeSenderName);
            this.SendParcelBox.Controls.Add(this.TextSendLabel);
            this.SendParcelBox.Controls.Add(this.ReceiverCheckBox);
            this.SendParcelBox.Controls.Add(this.SenderCheckBox);
            this.SendParcelBox.Controls.Add(this.PostofficeNumberSenderBox);
            this.SendParcelBox.Controls.Add(this.ReceiverIDBox);
            this.SendParcelBox.Controls.Add(this.SenderIDBox);
            this.SendParcelBox.Controls.Add(this.CreateParcel);
            this.SendParcelBox.Controls.Add(this.NameBox);
            this.SendParcelBox.Controls.Add(this.SurnameBox);
            this.SendParcelBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendParcelBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SendParcelBox.Location = new System.Drawing.Point(572, 0);
            this.SendParcelBox.Name = "SendParcelBox";
            this.SendParcelBox.Size = new System.Drawing.Size(228, 450);
            this.SendParcelBox.TabIndex = 3;
            this.SendParcelBox.TabStop = false;
            this.SendParcelBox.Text = "Відправити посилку";
            this.SendParcelBox.Enter += new System.EventHandler(this.SendParcelBox_Enter);
            // 
            // AgeTimePicker
            // 
            this.AgeTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.AgeTimePicker.Location = new System.Drawing.Point(3, 58);
            this.AgeTimePicker.Name = "AgeTimePicker";
            this.AgeTimePicker.Size = new System.Drawing.Size(222, 22);
            this.AgeTimePicker.TabIndex = 17;
            this.AgeTimePicker.ValueChanged += new System.EventHandler(this.AgeTimePicker_ValueChanged);
            // 
            // ParcelCapacity
            // 
            this.ParcelCapacity.Location = new System.Drawing.Point(6, 310);
            this.ParcelCapacity.Name = "ParcelCapacity";
            this.ParcelCapacity.Size = new System.Drawing.Size(173, 22);
            this.ParcelCapacity.TabIndex = 16;
            this.ParcelCapacity.Text = "Введіть об\'єм посилки:";
            this.ParcelCapacity.TextChanged += new System.EventHandler(this.ParcelCapacity_TextChanged);
            // 
            // PostOfficeReceiverName
            // 
            this.PostOfficeReceiverName.Location = new System.Drawing.Point(6, 282);
            this.PostOfficeReceiverName.Name = "PostOfficeReceiverName";
            this.PostOfficeReceiverName.Size = new System.Drawing.Size(211, 22);
            this.PostOfficeReceiverName.TabIndex = 15;
            this.PostOfficeReceiverName.Text = "Назва відділення отримувача";
            this.PostOfficeReceiverName.TextChanged += new System.EventHandler(this.PostOfficeReceiverName_TextChanged);
            // 
            // PostofficeNumberReceiverBox
            // 
            this.PostofficeNumberReceiverBox.Location = new System.Drawing.Point(6, 254);
            this.PostofficeNumberReceiverBox.Name = "PostofficeNumberReceiverBox";
            this.PostofficeNumberReceiverBox.Size = new System.Drawing.Size(211, 22);
            this.PostofficeNumberReceiverBox.TabIndex = 14;
            this.PostofficeNumberReceiverBox.Text = "Номер відділення отримувача";
            this.PostofficeNumberReceiverBox.TextChanged += new System.EventHandler(this.PostofficeNumberReceiverBox_TextChanged);
            // 
            // PostOfficeSenderName
            // 
            this.PostOfficeSenderName.Location = new System.Drawing.Point(6, 226);
            this.PostOfficeSenderName.Name = "PostOfficeSenderName";
            this.PostOfficeSenderName.Size = new System.Drawing.Size(211, 22);
            this.PostOfficeSenderName.TabIndex = 13;
            this.PostOfficeSenderName.Text = "Назва відділення отримувача";
            this.PostOfficeSenderName.TextChanged += new System.EventHandler(this.PostOfficeSenderName_TextChanged);
            // 
            // TextSendLabel
            // 
            this.TextSendLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextSendLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextSendLabel.Location = new System.Drawing.Point(3, 18);
            this.TextSendLabel.Name = "TextSendLabel";
            this.TextSendLabel.Size = new System.Drawing.Size(222, 40);
            this.TextSendLabel.TabIndex = 12;
            this.TextSendLabel.Text = "Введіть дані для відправлення посилки";
            this.TextSendLabel.Click += new System.EventHandler(this.TextSendLabel_Click);
            // 
            // ReceiverCheckBox
            // 
            this.ReceiverCheckBox.AutoSize = true;
            this.ReceiverCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReceiverCheckBox.Location = new System.Drawing.Point(6, 365);
            this.ReceiverCheckBox.Name = "ReceiverCheckBox";
            this.ReceiverCheckBox.Size = new System.Drawing.Size(161, 21);
            this.ReceiverCheckBox.TabIndex = 11;
            this.ReceiverCheckBox.Text = "Оплачує отримувач";
            this.ReceiverCheckBox.UseVisualStyleBackColor = false;
            this.ReceiverCheckBox.CheckedChanged += new System.EventHandler(this.ReceiverCheckBox_CheckedChanged);
            // 
            // SenderCheckBox
            // 
            this.SenderCheckBox.AutoSize = true;
            this.SenderCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SenderCheckBox.Location = new System.Drawing.Point(6, 338);
            this.SenderCheckBox.Name = "SenderCheckBox";
            this.SenderCheckBox.Size = new System.Drawing.Size(163, 21);
            this.SenderCheckBox.TabIndex = 10;
            this.SenderCheckBox.Text = "Оплачує відправник";
            this.SenderCheckBox.UseVisualStyleBackColor = false;
            this.SenderCheckBox.CheckedChanged += new System.EventHandler(this.SenderCheckBox_CheckedChanged);
            // 
            // PostofficeNumberSenderBox
            // 
            this.PostofficeNumberSenderBox.Location = new System.Drawing.Point(6, 198);
            this.PostofficeNumberSenderBox.Name = "PostofficeNumberSenderBox";
            this.PostofficeNumberSenderBox.Size = new System.Drawing.Size(211, 22);
            this.PostofficeNumberSenderBox.TabIndex = 9;
            this.PostofficeNumberSenderBox.Text = "Номер відділення відправника";
            this.PostofficeNumberSenderBox.TextChanged += new System.EventHandler(this.PostofficeNumberSenderBox_TextChanged);
            // 
            // ReceiverIDBox
            // 
            this.ReceiverIDBox.Location = new System.Drawing.Point(6, 170);
            this.ReceiverIDBox.Name = "ReceiverIDBox";
            this.ReceiverIDBox.Size = new System.Drawing.Size(173, 22);
            this.ReceiverIDBox.TabIndex = 8;
            this.ReceiverIDBox.Text = "Введіть ID отримувача";
            this.ReceiverIDBox.TextChanged += new System.EventHandler(this.ReceiverIDBox_TextChanged);
            // 
            // SenderIDBox
            // 
            this.SenderIDBox.Location = new System.Drawing.Point(6, 142);
            this.SenderIDBox.Name = "SenderIDBox";
            this.SenderIDBox.Size = new System.Drawing.Size(173, 22);
            this.SenderIDBox.TabIndex = 7;
            this.SenderIDBox.Text = "Введіть ваш ID";
            this.SenderIDBox.TextChanged += new System.EventHandler(this.SenderIDBox_TextChanged);
            // 
            // CreateParcel
            // 
            this.CreateParcel.AutoSize = true;
            this.CreateParcel.Location = new System.Drawing.Point(6, 392);
            this.CreateParcel.Name = "CreateParcel";
            this.CreateParcel.Size = new System.Drawing.Size(173, 29);
            this.CreateParcel.TabIndex = 6;
            this.CreateParcel.Text = "Створити посилку";
            this.CreateParcel.UseVisualStyleBackColor = true;
            this.CreateParcel.Click += new System.EventHandler(this.CreateParcel_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 86);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(173, 22);
            this.NameBox.TabIndex = 4;
            this.NameBox.Text = "Введіть ваше ім\'я";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(6, 114);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(173, 22);
            this.SurnameBox.TabIndex = 3;
            this.SurnameBox.Text = "Введіть ваше прізвище";
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
            // 
            // ParcelInfo
            // 
            this.ParcelInfo.BackColor = System.Drawing.Color.Transparent;
            this.ParcelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ParcelInfo.Location = new System.Drawing.Point(0, 272);
            this.ParcelInfo.Name = "ParcelInfo";
            this.ParcelInfo.Size = new System.Drawing.Size(572, 178);
            this.ParcelInfo.TabIndex = 18;
            this.ParcelInfo.Text = "Ваше відправлення:";
            this.ParcelInfo.Click += new System.EventHandler(this.ParcelInfo_Click);
            // 
            // SenderReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPostmail.Properties.Resources.banner2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParcelInfo);
            this.Controls.Add(this.SendParcelBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SenderReceiverForm";
            this.Text = "SenderReceiverForm";
            this.Load += new System.EventHandler(this.SenderReceiverForm_Load);
            this.SendParcelBox.ResumeLayout(false);
            this.SendParcelBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SendParcelBox;
        private System.Windows.Forms.TextBox ParcelCapacity;
        private System.Windows.Forms.TextBox PostOfficeReceiverName;
        private System.Windows.Forms.TextBox PostofficeNumberReceiverBox;
        private System.Windows.Forms.TextBox PostOfficeSenderName;
        private System.Windows.Forms.Label TextSendLabel;
        private System.Windows.Forms.CheckBox ReceiverCheckBox;
        private System.Windows.Forms.CheckBox SenderCheckBox;
        private System.Windows.Forms.TextBox PostofficeNumberSenderBox;
        private System.Windows.Forms.TextBox ReceiverIDBox;
        private System.Windows.Forms.TextBox SenderIDBox;
        private System.Windows.Forms.Button CreateParcel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label ParcelInfo;
        private System.Windows.Forms.DateTimePicker AgeTimePicker;
    }
}