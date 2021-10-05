using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Workers : Person
    {
        protected string Location_of_work { get; set; }

        public Workers(int age, string name, string surname, float id, string location_of_work) : base(age, name, surname, id)
        {
            Location_of_work = location_of_work;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Location of work: {Location_of_work}";
        }
    }
}
