using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Person
    {
        protected int Age { get; set; }
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected readonly float ID;

        protected Person(int age, string name, string surname, float id)
        {
            Age = age;
            Name = name;
            Surname = surname;
            ID = id;
        }

        public virtual void GetInfo()
        {
            Console.Write($"Age: {Age}, Name: {Name}, Surname: {Surname}, ID: {ID} ");
        }
    }
}
