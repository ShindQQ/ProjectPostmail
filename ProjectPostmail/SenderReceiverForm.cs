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
    public partial class SenderReceiverForm : Form
    {
        Sender sender;
        int postoffice_number_sender = default;
        int postoffice_number_receiver = default;
        double sender_id = default;
        double receiver_id = default;
        double capacity = default;
        double price = default;

        AutoCompleteStringCollection auto_postoffice_number = new AutoCompleteStringCollection();
        AutoCompleteStringCollection auto_postoffice_name = new AutoCompleteStringCollection();

        PostOffice[] postoffices = new PostOffice[20];

        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        private Sender InitializeSender(DateTime age, string name, string surname, double sender_id, double receiver_id, int postoffice_number_sender, int postoffice_number_receiver, double capacity, bool payment, double price)
        {
            try
            {
                return new Sender(age, name, surname, sender_id, receiver_id, postoffice_number_sender, postoffice_number_receiver, capacity, payment, price);
            }
            catch (AgeException exp)
            {
                MessageBox.Show($"{exp.Message}, Value: {exp.Value}");
                return null;
            }
        }

        private void AutoComplete(TextBox name, AutoCompleteStringCollection collection)
        {
            name.AutoCompleteCustomSource = collection;
            name.AutoCompleteMode = AutoCompleteMode.Suggest;
            name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public SenderReceiverForm()
        {
            InitializeComponent();
        }

        private void SenderReceiverForm_Load(object sender, EventArgs e)
        {

        }

        private void SendParcelBox_Enter(object sender, EventArgs e)
        {

        }

        private void AgeTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SenderIDBox_TextChanged(object sender, EventArgs e)
        {
            bool check = double.TryParse(SenderIDBox.Text, NumberStyles.Currency, formatter, out sender_id);

            if (!check)
            {
                MessageBox.Show("Mistake with data");
            }
        }

        private void ReceiverIDBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(ReceiverIDBox.Text, NumberStyles.Currency, formatter, out receiver_id))
            {
                MessageBox.Show("Mistake with data");
            }
        }

        private void PostofficeNumberSenderBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PostofficeNumberSenderBox.Text, out postoffice_number_sender))
            {
                MessageBox.Show("Mistake with data");
            }

            AutoComplete(PostofficeNumberSenderBox, auto_postoffice_number);
        }

        private void PostOfficeSenderName_TextChanged(object sender, EventArgs e)
        {
            AutoComplete(PostOfficeSenderName, auto_postoffice_name);
        }

        private void PostofficeNumberReceiverBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PostofficeNumberReceiverBox.Text, out postoffice_number_receiver))
            {
                MessageBox.Show("Mistake with data");
            }

            AutoComplete(PostofficeNumberReceiverBox, auto_postoffice_number);
        }

        private void PostOfficeReceiverName_TextChanged(object sender, EventArgs e)
        {
            AutoComplete(PostOfficeReceiverName, auto_postoffice_name);
        }

        private void ParcelCapacity_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(ParcelCapacity.Text, out capacity))
            {
                MessageBox.Show("Mistake with data");
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
            if (this.sender != null)
            {
                ParcelInfo.Text = "Ваше відправлення: " + this.sender.GetInfo();
            }
        }

        private void CreateParcel_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    postoffices[postoffice_number_sender] ??= new PostOffice(postoffice_number_sender, ((new Random()).NextDouble(), (new Random()).NextDouble(), (new Random()).NextDouble()), (new Random()).NextDouble(), PostOfficeSenderName.Text, 0);
                }
                catch (PostofficeNumberException exp)
                {
                    MessageBox.Show($"{exp.Message}, Value: {exp.Value}");
                    postoffices[postoffice_number_sender] = null;
                }

                try
                {
                    postoffices[postoffice_number_receiver] ??= new PostOffice(postoffice_number_receiver, ((new Random()).NextDouble() + 1, (new Random()).NextDouble() + 1, (new Random()).NextDouble() + 1), (new Random()).NextDouble(), PostOfficeReceiverName.Text, 0);
                }
                catch (PostofficeNumberException exp)
                {
                    MessageBox.Show($"{exp.Message}, Value: {exp.Value}");
                    postoffices[postoffice_number_receiver] = null;
                }

                if (postoffices[postoffice_number_sender] != null && postoffices[postoffice_number_receiver] != null)
                {
                    price = Math.Sqrt(Math.Pow(postoffices[postoffice_number_receiver].Location.Item1 - postoffices[postoffice_number_sender].Location.Item1, 2) + Math.Pow(postoffices[postoffice_number_receiver].Location.Item2 - postoffices[postoffice_number_sender].Location.Item2, 2) + Math.Pow(postoffices[postoffice_number_receiver].Location.Item3 - postoffices[postoffice_number_sender].Location.Item3, 2));
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
                    this.sender = InitializeSender(AgeTimePicker.Value, NameBox.Text, SurnameBox.Text, sender_id, receiver_id, postoffice_number_sender, postoffice_number_receiver, capacity, true, price);
                }
                else if (ReceiverCheckBox.Checked == true)
                {
                    this.sender = InitializeSender(AgeTimePicker.Value, NameBox.Text, SurnameBox.Text, sender_id, receiver_id, postoffice_number_sender, postoffice_number_receiver, capacity, false, price);
                }

                if (this.sender != null)
                {
                    ParcelInfo.Text = "Ваше відправлення: " + this.sender.GetInfo();
                    postoffices[postoffice_number_receiver].ChangeTotalCapacity(capacity);

                    auto_postoffice_number.Add(postoffice_number_sender.ToString());
                    auto_postoffice_number.Add(postoffice_number_receiver.ToString());
                    auto_postoffice_name.Add(PostOfficeReceiverName.Text);
                    auto_postoffice_name.Add(PostOfficeSenderName.Text);
                }
            }
            catch (IndexOutOfRangeException exp)
            {
                MessageBox.Show($"Exception in:{exp.StackTrace}");
            }
        }

        private void TextSendLabel_Click(object sender, EventArgs e)
        {

        }
    }
}