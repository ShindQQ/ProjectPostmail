using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class PostMail
    {
        protected readonly int _id;
        protected string _name { get; set; }
        protected double _capacity { get; set; }

        protected static double _total_capacity = default(double);
        protected static int _offices_ammount = default(int);
        
        public PostMail(int id, string name, double capacity)
        {
            _id = id;
            _name = name;
            _capacity = capacity;
            _total_capacity += capacity;
            _offices_ammount++;
        }

        public virtual void GetInfo()
        {
            Console.Write($"ID: {_id}, Name: {_name}, Capacity: {_capacity} ");
        }

        public void GetID()
        {
            Console.WriteLine($"{_id}");
        }

        public void ChangeTotalCapacity(double value)
        {
            _total_capacity -= value;
            if(_total_capacity < 0)
            {
                _total_capacity = default(double);
            }
        }
    }
}