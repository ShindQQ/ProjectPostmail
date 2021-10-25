using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Workers : Person
    {
        protected int _postoffice_number;

        public Workers(DateTime age, string name, string surname, double id, int postoffice_number) : base(age, name, surname, id)
        {
            _postoffice_number = postoffice_number;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Location of work: {_postoffice_number}";
        }

        public int Postoffice_Number
        {
            get
            {
                return _postoffice_number;
            }
            set
            {
                _postoffice_number = value;
            }
        }
    }
}