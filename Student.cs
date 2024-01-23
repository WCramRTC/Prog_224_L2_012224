using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_L2_012224
{
    public class Student : Person
    {
        string _schoolId;
        List<int> _grades;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
