﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Receiver : Person
    {
        private readonly float _sender_id;
        private readonly int _postoffice_number;
        private readonly double _price;

        public Receiver(int age, string name, string surname, float id, float sender_id, int postoffice_number, double price) : base(age, name, surname, id)
        {
            _sender_id = sender_id;
            _postoffice_number = postoffice_number;
            _price = price;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Sender id: {_sender_id}, Postoffice number: {_postoffice_number}");
        }
    }
}