
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
            this.FormAccess = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PostofficeGroupBox = new System.Windows.Forms.GroupBox();
            this.PostofficeNumberBox = new System.Windows.Forms.TextBox();
            this.PostofficeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormAccess
            // 
            this.FormAccess.Location = new System.Drawing.Point(-40, -10);
            this.FormAccess.Name = "FormAccess";
            this.FormAccess.Size = new System.Drawing.Size(848, 471);
            this.FormAccess.TabIndex = 0;
            this.FormAccess.Click += new System.EventHandler(this.FormAccess_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(332, 243);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(113, 22);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.Text = "Введіть пароль";
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyUp);
            // 
            // PostofficeGroupBox
            // 
            this.PostofficeGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PostofficeGroupBox.Controls.Add(this.PostofficeNumberBox);
            this.PostofficeGroupBox.Location = new System.Drawing.Point(172, 26);
            this.PostofficeGroupBox.Name = "PostofficeGroupBox";
            this.PostofficeGroupBox.Size = new System.Drawing.Size(200, 394);
            this.PostofficeGroupBox.TabIndex = 3;
            this.PostofficeGroupBox.TabStop = false;
            this.PostofficeGroupBox.Text = "Відділення № ";
            this.PostofficeGroupBox.Enter += new System.EventHandler(this.PostofficeGroupBox_Enter);
            // 
            // PostofficeNumberBox
            // 
            this.PostofficeNumberBox.Location = new System.Drawing.Point(3, 18);
            this.PostofficeNumberBox.Name = "PostofficeNumberBox";
            this.PostofficeNumberBox.Size = new System.Drawing.Size(175, 22);
            this.PostofficeNumberBox.TabIndex = 0;
            this.PostofficeNumberBox.Text = "Введіть номер відділення";
            this.PostofficeNumberBox.TextChanged += new System.EventHandler(this.PostofficeNumberBox_TextChanged);
            this.PostofficeNumberBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PostofficeNumberBox_KeyUp);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPostmail.Properties.Resources.banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.FormAccess);
            this.Controls.Add(this.PostofficeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.PostofficeGroupBox.ResumeLayout(false);
            this.PostofficeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormAccess;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.GroupBox PostofficeGroupBox;
        private System.Windows.Forms.TextBox PostofficeNumberBox;
    }
}