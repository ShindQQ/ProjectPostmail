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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sender _sender = new Sender(0, "Sender", "Surname_Sender", (float)122.5, (float)155.5, 5, true, 260);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}