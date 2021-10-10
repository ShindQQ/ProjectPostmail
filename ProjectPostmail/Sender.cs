using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Sender : Person
    {
        private readonly double _receiver_id;
        private readonly int _postoffice_number_sender;
        private readonly int _postoffice_number_receiver;
        private readonly double _capacity;
        private readonly bool _payment;
        private readonly double _price;

        public Sender(int age, string name, string surname, double sender_id, double receiver_id, int postoffice_number_sender, int postoffice_number_receiver, double capacity, bool payment, double price) : base(age, name, surname, sender_id)
        {
            _receiver_id = receiver_id;
            _postoffice_number_sender = postoffice_number_sender;
            _postoffice_number_receiver = postoffice_number_receiver;
            _capacity = capacity;
            _payment = payment;
            _price = price;
        }

        public override string GetInfo()
        {
            if (_payment == true)
            {
                return base.GetInfo() + $"Receiver id: {_receiver_id}, Postoffice number: {_postoffice_number_sender}, Capacity of parcel: {_capacity}, Who pays: Sender, Price:{_price}";
            }
            else
            {
                return base.GetInfo() + $"Receiver id: {_receiver_id}, Postoffice number: {_postoffice_number_sender}, Capacity of parcel: {_capacity},  Who pays: Receiver, Price:{_price}";
            }
        }

        public double GetReceiverID()
        {
            return _receiver_id;
        }

        public int GetPostofficeNumberSender()
        {
            return _postoffice_number_sender;
        }

        public int GetPostofficeNumberReceiver()
        {
            return _postoffice_number_receiver;
        }

        public bool GetPayment()
        {
            return _payment;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}