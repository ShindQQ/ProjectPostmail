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

        public Sender(DateTime age, string name, string surname, double sender_id, double receiver_id, int postoffice_number_sender, int postoffice_number_receiver, double capacity, bool payment, double price) : base(age, name, surname, sender_id)
        {
            _receiver_id = receiver_id;

            if(postoffice_number_receiver < 0)
            {
                throw new PostofficeNumberException("Receiver PostofficeNumber is less than 0", postoffice_number_receiver);
            }
            else if(postoffice_number_sender < 0)
            {
                throw new PostofficeNumberException("Sender PostofficeNumber is less than 0", postoffice_number_sender);
            }
            else
            {
                _postoffice_number_sender = postoffice_number_sender;
                _postoffice_number_receiver = postoffice_number_receiver;
            }
            
            _capacity = capacity;
            _payment = payment;
            _price = price;
        }

        public override string Print()
        {
            if (Printer != null)
            {
                return Printer.Print(this);
            }
            else
            {
                return GetInfo();
            }
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

        public double Receiver_ID
        {
            get
            {
                return _receiver_id;
            }
        }

        public int PostofficeNumberSender
        {
            get
            {
                return _postoffice_number_sender;
            }
        }

        public int PostofficeNumberReceiver
        {
            get
            {
                return _postoffice_number_receiver;
            }
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public bool Payment
        {
            get
            {
                return _payment;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }
    }
}