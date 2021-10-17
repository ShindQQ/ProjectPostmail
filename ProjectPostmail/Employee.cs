using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Employee : Workers
    {
        public Employee(DateTime age, string name, string second_name, double id, string location_of_work) : base(age, name, second_name, id, location_of_work)
        {
        
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
