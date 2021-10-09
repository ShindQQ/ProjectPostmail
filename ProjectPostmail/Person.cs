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
        protected readonly float _id;

        protected Person(int age, string name, string surname, float id)
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