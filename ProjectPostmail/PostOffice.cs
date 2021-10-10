using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class PostOffice : PostMail
    {
        private readonly double _department;
        private (double, double, double) _location;

        public PostOffice(double department, (double, double, double) location, double id, string name, double capacity) : base(id, name, capacity)
        {
            _department = department;
            _location = location;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Department: {_department}, Location: {_location}";
        }

        public double GetDepartment()
        {
            return _department;
        }

        public void SetLocation((double, double, double) location)
        {
            _location = location;
        }

        public (double, double, double) GetLocation()
        {
            return _location;
        }
    }
}