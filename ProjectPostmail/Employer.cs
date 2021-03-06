using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Employer : Workers, IComparable
    {
        private int _ammount_of_workers;

        public Employer(DateTime age, string name, string second_name, double id, int postoffice_number, int ammount_of_workers) : base(age, name, second_name, id, postoffice_number)
        {
            if (ammount_of_workers < 0)
            {
                throw new WorkersAmmountException("Ammount of workers is less than 0", ammount_of_workers);
            }
            else
            {
                _ammount_of_workers = ammount_of_workers;
            }
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
            return base.GetInfo() + $"Ammount of workers working on this Employer: {_ammount_of_workers}";
        }

        public int Ammount_Of_Workers
        {
            get
            {
                return _ammount_of_workers;
            }
            set
            {
                _ammount_of_workers = value;
            }
        }

        public int CompareTo(object obj)
        {
            return Postoffice_Number.CompareTo(((Employer)obj).Postoffice_Number);
        }
    }
}