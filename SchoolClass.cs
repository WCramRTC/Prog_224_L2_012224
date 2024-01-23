using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_L2_012224
{
    internal class SchoolClass
    {
        public enum Modality { InPerson, Online, Hybrid }

        string _name;
        string _roomNumber;
        Modality _modality;
        // Aggregate Field
        Professor _classProfessor;

        // Containment
        List<Student> _roster;

        public SchoolClass(string name, string roomNumber, Modality modality, Professor classProfessor)
        {
            _name = name;
            _roomNumber = roomNumber;
            _modality = modality;
            _classProfessor = classProfessor;
            _roster = new List<Student>();
        }

        public string Name { get => _name; set => _name = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        internal Modality Modality1 { get => _modality; set => _modality = value; }
        public Professor ClassProfessor { get => _classProfessor; set => _classProfessor = value; }
        //internal List<Student> Roster { get => _roster; }

        public void AddStudent(Student student)
        {
            _roster.Add(student);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{_name}");
            Console.WriteLine($"{_classProfessor.ToString()}");
            foreach (Student student in _roster)
            {
                Console.WriteLine(student.ToString()) ;
            }
        }

        public override string? ToString()
        {
            // Class Name
            // Class Number
            // Modality
            // Professor
            string formattedString = $"Class Name: {_name}\n" +
                $"Class Number: {_roomNumber}\n" +
                $"Modality: {_modality}\n" +
                $"{_classProfessor.ToString()}";


            return formattedString;
        }
    }
}
