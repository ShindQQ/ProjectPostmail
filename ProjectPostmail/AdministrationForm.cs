using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPostmail
{
    public partial class AdministrationForm : Form
    {
        string password = "admin";
        int postofficenumber;

        public AdministrationForm()
        {
            InitializeComponent();
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {

        }

        private void FormAccess_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (PasswordBox.Text == password)
                {
                    FormAccess.Visible = false;
                    PasswordBox.Visible = false;
                }
            }
        }

        private void PostofficeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PostofficeNumberBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PostofficeNumberBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(PostofficeNumberBox.Text, out postofficenumber))
                {
                    PostofficeGroupBox.Text = "Відділення №" + postofficenumber.ToString();
                }
                else
                {
                    PostofficeGroupBox.Text = "Відділення № 0";
                }
            }
        }

    }
}
