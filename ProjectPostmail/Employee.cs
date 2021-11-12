using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Employee : Workers, IComparable
    {
        public Employee(DateTime age, string name, string second_name, double id, int postoffice_number) : base(age, name, second_name, id, postoffice_number)
        {
        
        }

        public override string Print()
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

        public override string GetInfo()
        {
            return base.GetInfo();
        }

        public int CompareTo(object obj)
        {
            return Postoffice_Number.CompareTo(((Employer)obj).Postoffice_Number);
        }
    }
}