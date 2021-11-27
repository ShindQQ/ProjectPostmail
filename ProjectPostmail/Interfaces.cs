using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    interface IReturnable
    {
        string Print(object obj);
    }

    interface IPrintable
    {
        string Print(object obj);
    }

    class PersonShowNameSurnameInfo : IReturnable, IPrintable
    {
        string IReturnable.Print(object obj)
        {
            Person person = obj as Person;
            return $"Name: {person.Name}, Surname: {person.Surname}";
        }

        string IPrintable.Print(object obj)
        {
            Person person = obj as Person;
            return $"Name: {person.Name}, Surname: {person.Surname}";
        }
    }
}
