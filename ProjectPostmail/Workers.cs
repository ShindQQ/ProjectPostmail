using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Workers : Person
    {
        protected string _location_of_work;

        public Workers(int age, string name, string surname, double id, string location_of_work) : base(age, name, surname, id)
        {
            _location_of_work = location_of_work;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Location of work: {_location_of_work}";
        }

        public void SetLocationOfWork(string location_of_work)
        {
            _location_of_work = location_of_work;
        }

        public string GetLocationOfWork()
        {
            return _location_of_work;
        }
    }
}