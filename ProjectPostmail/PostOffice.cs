using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class PostOffice : PostMail
    {
        private readonly float _department;
        private string _location;

        public PostOffice(float department, string location, int id, string name, double capacity) : base(id, name, capacity)
        {
            _department = department;
            _location = location;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Department: {_department}, Location: {_location}");
        }

        public void GetDepartment()
        {
            Console.WriteLine($"{_department}");
        }

        public void GetLocation()
        {
            Console.WriteLine($"{_location}");
        }

        public void SetLocation(string location)
        {
            _location = location;
        }
    }
}