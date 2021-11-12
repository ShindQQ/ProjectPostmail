using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    abstract class Person
    {
        protected DateTime _age;
        protected string _name;
        protected string _surname;
        protected readonly double _id;

        public IReturnable Printer { get; set; }

        protected Person(DateTime age, string name, string surname, double id)
        {
            if (age.ToString("d") == DateTime.Today.ToString("d"))
            {
                throw new AgeException("Your date of birth can`t be today", DateTime.Today.ToString("d"));
            }
            else
            {
                Age = age;
            }
            Name = name;
            Surname = surname;
            _id = id;

            Printer = null;
        }

        public virtual string Print()
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

        public virtual string GetInfo()
        {
            return $"Age: {_age.ToString("d")}, Name: {_name}, Surname: {_surname}, ID: {_id} ";
        }

        public DateTime Age
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
            DateTime number;
            bool check = DateTime.TryParse(age, out number);

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