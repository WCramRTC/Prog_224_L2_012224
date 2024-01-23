using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_L2_012224
{
    public class Professor : Person
    {

        // Inheriet from Person
        // In the class declaration, colon :, class name
        // Same or less accesible
        // Each class must generator it's own constructor

        string _empNumber;
        double _salary;
        float _timeOff;

        public Professor(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public string EmpNumber { get => _empNumber; set => _empNumber = value; }
        public double Salary { get => _salary; set => _salary = value; }
        public float TimeOff { get => _timeOff; set => _timeOff = value; }

        public override string ToString()
        {
            return "Professor " + base.ToString();
        }
    }
}
