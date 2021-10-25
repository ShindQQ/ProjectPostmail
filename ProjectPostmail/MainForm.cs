using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjectPostmail
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdministrationForm AdminForm = new AdministrationForm();
            AdminForm.Show();
        }

        private void ParcelButton_Click(object sender, EventArgs e)
        {
            SenderReceiverForm ParcelForm = new SenderReceiverForm();
            ParcelForm.Show();
        }
    }
}