using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_L2_012224
{
    public class Person
    {
        string _firstName;
        string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public override string? ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
