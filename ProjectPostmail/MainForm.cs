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
        Sender _sender;
        int age;
        int postoffice_number;
        double sender_id;
        double receiver_id;

        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = int.TryParse(AgeBox.Text, out age);

                if (!check)
                {
                    MessageBox.Show("Mistake with data");
                }
            }
            catch
            {
                MessageBox.Show("Exception happened");
            }
        }


        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SenderIDBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = double.TryParse(SenderIDBox.Text, NumberStyles.Currency, formatter, out sender_id);

                if (!check)
                {
                    MessageBox.Show("Mistake with data");
                }
            }
            catch
            {
                MessageBox.Show("Exception happened");
            }
        }

        private void ReceiverIDBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = double.TryParse(ReceiverIDBox.Text, NumberStyles.Currency, formatter, out receiver_id);

                if (!check)
                {
                    MessageBox.Show("Mistake with data");
                }
            }
            catch
            {
                MessageBox.Show("Exception happened");
            }
        }

        private void PostofficeNumberBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = int.TryParse(PostofficeNumberBox.Text, out postoffice_number);

                if (!check)
                {
                    MessageBox.Show("Mistake with data");
                }
            }
            catch
            {
                MessageBox.Show("Exception happened");
            }
        }

        private void SenderCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ReceiverCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateParcel_Click(object sender, EventArgs e)
        {
            if (SenderCheckBox.Checked == false && ReceiverCheckBox.Checked == false)
            {
                MessageBox.Show("Ви не обрали хто платить за посилку!");
            }
            else if (SenderCheckBox.Checked == true && ReceiverCheckBox.Checked == true)
            {
                MessageBox.Show("Ви обрали що за посилку платять двоє!");
            }
            else if (SenderCheckBox.Checked == true)
            {
                _sender = new Sender(age, NameBox.Text, SurnameBox.Text, sender_id, receiver_id, postoffice_number, SenderCheckBox.Checked, 260);
            }
            else if (ReceiverCheckBox.Checked == true)
            {
                _sender = new Sender(age, NameBox.Text, SurnameBox.Text, sender_id, receiver_id, postoffice_number, ReceiverCheckBox.Checked, 260);
            }

            if (_sender != null)
            {
                MessageBox.Show(_sender.GetInfo());
            }
        }
    }
}