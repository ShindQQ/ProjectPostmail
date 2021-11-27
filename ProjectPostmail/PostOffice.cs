using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class PostOffice : PostMail
    {
        public delegate void DistanceShow(string message);
        public event DistanceShow Notify;

        private readonly double _department;
        private (double, double, double) _location;

        public PostOffice(double department, (double, double, double) location, double id, string name, double capacity) : base(id, name, capacity)
        {
            if (department < 0)
            {
                throw new DepartmentException("Department number is less or equal 0", department);
            }
            else
            {
                _department = department;
            }
            Location = location;
        }

        public override string GetInfo()
        {
            Notify?.Invoke((Math.Sqrt(Math.Pow(_location.Item1, 2) + Math.Pow(_location.Item2, 2) + Math.Pow(_location.Item3, 2))).ToString());
            return base.GetInfo() + $"Department: {_department}, Location: {_location}";
        }

        public double Department
        {
            get
            {
                return _department;
            }
        }

        public (double, double, double) Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
    }
}