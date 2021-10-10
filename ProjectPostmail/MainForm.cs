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
        int age = default(int);
        int postoffice_number_sender = default(int);
        int postoffice_number_receiver = default(int);
        double sender_id = default(double);
        double receiver_id = default(double);
        double capacity = default(double);
        double price = default(double);

        PostOffice[] postoffices = new PostOffice[20];

        // Random random = new Random();

        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SendParcelBox_Enter(object sender, EventArgs e)
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

        private void PostofficeNumberSenderBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = int.TryParse(PostofficeNumberSenderBox.Text, out postoffice_number_sender);

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

        private void PostOfficeSenderName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostofficeNumberReceiverBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = int.TryParse(PostofficeNumberReceiverBox.Text, out postoffice_number_receiver);

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

        private void PostOfficeReceiverName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ParcelCapacity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = double.TryParse(ParcelCapacity.Text, out capacity);

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

        private void ParcelInfo_Click(object sender, EventArgs e)
        {
            if (_sender != null)
            {
                ParcelInfo.Text = "Ваше відправлення: " + _sender.GetInfo();
            }
        }

        private void CreateParcel_Click(object sender, EventArgs e)
        {
            if(postoffices[postoffice_number_sender] == null)
            {
                postoffices[postoffice_number_sender] = new PostOffice(postoffice_number_sender, ((new Random()).NextDouble(), (new Random()).NextDouble(), (new Random()).NextDouble()), (new Random()).NextDouble(), PostOfficeSenderName.Text, 0);
            }
            if (postoffices[postoffice_number_receiver] == null)
            {
                postoffices[postoffice_number_receiver] = new PostOffice(postoffice_number_receiver, ((new Random()).NextDouble() + 1, (new Random()).NextDouble() + 1, (new Random()).NextDouble() + 1), (new Random()).NextDouble(), PostOfficeReceiverName.Text, 0);
            }

            if (postoffices[postoffice_number_sender] != null && postoffices[postoffice_number_receiver] != null)
            {
                price = Math.Sqrt(Math.Pow(postoffices[postoffice_number_receiver].GetLocation().Item1 - postoffices[postoffice_number_sender].GetLocation().Item1, 2) + Math.Pow(postoffices[postoffice_number_receiver].GetLocation().Item2 - postoffices[postoffice_number_sender].GetLocation().Item2, 2) + Math.Pow(postoffices[postoffice_number_receiver].GetLocation().Item3 - postoffices[postoffice_number_sender].GetLocation().Item3, 2)); 
            }

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
                _sender = new Sender(age, NameBox.Text, SurnameBox.Text, sender_id, receiver_id, postoffice_number_sender, postoffice_number_receiver, capacity, true, price);
            }
            else if (ReceiverCheckBox.Checked == true)
            {
                _sender = new Sender(age, NameBox.Text, SurnameBox.Text, sender_id, receiver_id, postoffice_number_sender, postoffice_number_receiver, capacity, false, price);
            }

            if (_sender != null)
            {
                ParcelInfo.Text = "Ваше відправлення: " + _sender.GetInfo();
            }
        }

        private void TextSendLabel_Click(object sender, EventArgs e)
        {

        }
    }
}