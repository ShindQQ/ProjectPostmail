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
            _age = age;
            _name = name;
            _surname = surname;
            _id = id;
        }

        public virtual string GetInfo()
        {
            return $"Age: {_age}, Name: {_name}, Surname: {_surname}, ID: {_id} ";
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public bool SetAge(string age)
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

        public int GetAge()
        {
            return _age;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetSurname(string surname)
        {
            _surname = surname;
        }

        public string GetSurname()
        {
            return _surname;
        }

        public double GetID()
        {
            return _id;
        }
    }
}