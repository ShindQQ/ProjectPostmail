using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPostmail
{
    class AgeException : Exception
    {
        public int Value { get; }

        public AgeException(string message, int value) : base(message)
        {
            Value = value;
        }

        public AgeException(string message, Exception InnerException, int value) : base(message, InnerException)
        {
            Value = value;
        }
    }

    class DepartmentException : Exception
    {
        public double Value { get; }

        public DepartmentException(string message, double value) : base(message)
        {
            Value = value;
        }

        public DepartmentException(string message, Exception InnerException, double value) : base(message, InnerException)
        {
            Value = value;
        }
    }

    class CapacityException : Exception
    {
        public double Value { get; }

        public CapacityException(string message, double value) : base(message)
        {
            Value = value;
        }

        public CapacityException(string message, Exception InnerException, double value) : base(message, InnerException)
        {
            Value = value;
        }
    }

    class PostofficeNumberException : Exception
    {
        public int Value { get; }

        public PostofficeNumberException(string message, int value) : base(message)
        {
            Value = value;
        }

        public PostofficeNumberException(string message, Exception InnerException, int value) : base(message, InnerException)
        {
            Value = value;
        }
    }

    class WorkersAmmountException : Exception
    {
        public int Value { get; }

        public WorkersAmmountException(string message, int value) : base(message)
        {
            Value = value;
        }

        public WorkersAmmountException(string message, Exception InnerException, int value) : base(message, InnerException)
        {
            Value = value;
        }
    }
}