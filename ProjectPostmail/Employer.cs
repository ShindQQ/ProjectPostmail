using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class Employer : Workers
    {
        private int Ammount_of_workers { get; set; }

        public Employer(int age, string name, string second_name, float id, string location_of_work, int ammount_of_workers) : base(age, name, second_name, id, location_of_work)
        {
            Ammount_of_workers = ammount_of_workers;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Ammount of workers working on this Employer: {Ammount_of_workers}");
        }
    }
}
