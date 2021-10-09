using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class PostMail
    {
        protected readonly double _id;
        protected string _name;
        protected double _capacity;

        protected static double _total_capacity = default(double);
        protected static int _offices_ammount = default(int);
        
        public PostMail(double id, string name, double capacity)
        {
            _id = id;
            _name = name;
            _capacity = capacity;
            _total_capacity += capacity;
            _offices_ammount++;
        }

        public virtual string GetInfo()
        {
            return $"ID: {_id}, Name: {_name}, Capacity: {_capacity} ";
        }

        public double GetID()
        {
            return _id;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetCapacity(double capacity)
        {
            _capacity = capacity;
        }

        public double GetCapacity()
        {
            return _capacity;
        }

        public void ChangeTotalCapacity(double value)
        {
            _total_capacity -= value;
            if (_total_capacity < 0)
            {
                _total_capacity = default(double);
            }
        }
    }
}