using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Employee : Workers
    {
        public Employee(DateTime age, string name, string second_name, double id, int postoffice_number) : base(age, name, second_name, id, postoffice_number)
        {
        
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}