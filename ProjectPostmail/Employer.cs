using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Employer : Workers
    {
        private int _ammount_of_workers;

        public Employer(int age, string name, string second_name, float id, string location_of_work, int ammount_of_workers) : base(age, name, second_name, id, location_of_work)
        {
            _ammount_of_workers = ammount_of_workers;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Ammount of workers working on this Employer: {_ammount_of_workers}";
        }

        public void SetAmmountOfWorkers(int ammount_of_workers)
        {
            _ammount_of_workers = ammount_of_workers;
        }

        public int GetAmmountOfWorkers()
        {
            return _ammount_of_workers;
        }
    }
}