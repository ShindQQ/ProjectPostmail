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
        Sender _sender;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _sender = new Sender(0, "Sender", "Surname_Sender", (float)122.5, (float)155.5, 5, true, 260);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_sender != null)
            {
                try
                {
                    bool check = _sender.SetAge(AgeBox.Text);

                    if (!check)
                    {
                        MessageBox.Show("Mistake with data");
                    }
                }
                catch
                {
                    MessageBox.Show("Exception happened");
                }

                MessageBox.Show(_sender.GetAge().ToString());
            }
            else
            {
                MessageBox.Show("Create new delievery!");
            }
        }
    }
}