using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    abstract class Person
    {
        protected int _age;
        protected string _name;
        protected string _surname;
        protected readonly double _id;

        protected Person(int age, string name, string surname, double id)
        {
            if (age <= 0)
            {
                throw new AgeException("Age is less or equal 0", age);
            }
            else
            {
                Age = age;
            }
            Name = name;
            Surname = surname;
            _id = id;
        }

        public virtual string GetInfo()
        {
            return $"Age: {_age}, Name: {_name}, Surname: {_surname}, ID: {_id} ";
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public double ID
        {
            get
            {
                return _id;
            }
        }

        public bool SetStringAge(string age)
        {
            int number;
            bool check = int.TryParse(age, out number);

            if(check == true)
            {
                _age = number;
                return check;
            }
            else
            {
                return check;
            }
        }
    }
}