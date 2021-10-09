using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Sender : Person
    {
        private readonly float _receiver_id;
        private readonly int _postoffice_number;
        private readonly bool _payment;
        private readonly double _price;

        public Sender(int age, string name, string surname, float id, float receiver_id, int postoffice_number, bool payment, double price) : base(age, name, surname, id)
        {
            _receiver_id = receiver_id;
            _postoffice_number = postoffice_number;
            _payment = payment;
            _price = price;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Receiver id: {_receiver_id}, Postoffice number: {_postoffice_number}, Who pays: {_payment}, Price:{_price}";
        }

        public float GetReceiverID()
        {
            return _receiver_id;
        }

        public int GetPostofficeNumber()
        {
            return _postoffice_number;
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