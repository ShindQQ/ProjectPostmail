using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Receiver : Person
    {
        private readonly double _sender_id;
        private readonly int _postoffice_number_receiver;
        private readonly int _postoffice_number_sender;
        private readonly double _price;

        public Receiver(DateTime age, string name, string surname, double id, double sender_id, int postoffice_number_receiver, int postoffice_number_sender, double price) : base(age, name, surname, id)
        {
            _sender_id = sender_id;

            if (postoffice_number_receiver < 0)
            {
                throw new PostofficeNumberException("Receiver PostofficeNumber is less than 0", postoffice_number_receiver);
            }
            else if (postoffice_number_sender < 0)
            {
                throw new PostofficeNumberException("Sender PostofficeNumber is less than 0", postoffice_number_sender);
            }
            else
            {
                _postoffice_number_sender = postoffice_number_sender;
                _postoffice_number_receiver = postoffice_number_receiver;
            }

            _price = price;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Sender id: {_sender_id}, Postoffice number: {_postoffice_number_receiver}";
        }

        public double Sender_ID
        {
            get
            {
                return _sender_id;
            }
        }

        public int PostofficeNumberReceiver
        {
            get
            {
                return _postoffice_number_receiver;
            }
        }

        public int PostofficeNumberSender
        {
            get
            {
                return _postoffice_number_sender;
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