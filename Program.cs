namespace Prog_224_L2_012224
{
    internal class Program
    {
        static List<Professor> _professors;
        static List<Student> _students;

        static void Main(string[] args)
        {
            PopulateDatabases();

            List<Object> objects = new List<object>();

            objects.Add(new Student("Manjula","Rajan"));
            objects.Add(new Professor("Manjula","Rajan"));

            FullTimeProfessor manjula = (FullTimeProfessor)objects[1];
            // Object
            // Person
            // Professor
            // FUlltimeProfessor

            Person p = manjula;

            p.


            // Student
            /// School Class



            Console.WriteLine();

            ////Person will = new Person("Will", "Cram");

            //Professor will = new Professor("Will", "Cram");
            //Console.WriteLine(will.ToString());

            //FullTimeProfessor josh = new FullTimeProfessor("Josh", "Emery");

            //// Polymorphism
            //// Many Forms
            //Object o = new object();
            

            //_professors.Add(_students[4]);

            // Aggregation
            // Has A - Composed of many smaller objects
            // Our Students and Professors are agregation because they exist OUTSIDE of the class

            // Containment
            // The Roaster for a class is Contained inside of a school class object, so it does not exisit unless the class does
            //SchoolClass prog224 = new SchoolClass("Programming 224", "Online", SchoolClass.Modality.Online, _professors[0]);

            //// Abstraction
            //// Hiding the information in the class, because our own custom methods and functionality
            //foreach (Student student in _students)
            //{
            //    prog224.AddStudent(student);
            //}
            //prog224.DisplayInfo();



            // Containment


            // Class for SchoolClass
            // Student

            // Inheritence
            // How To
            // Polymorphism

            // virtual
            // override
            // new


        } // Main

        public static void PopulateDatabases()
        {
            //Professor will = new Professor("Will", "Cram");
            //Professor josh = new Professor("Josh", "Emery");
            //_professors = new List<Professor>();
            //_students = new List<Student>();

            //_professors.Add(will);
            //_professors.Add(josh);

            //_students.Add(new Student("David", "Abarca"));
            //_students.Add(new Student("Lisa", "Cai"));
            //_students.Add(new Student("Matthew", "Vargas"));
            //_students.Add(new Student("Manjula", "Rajan"));
            //_students.Add(new Student("Hafsa", "Rajan"));
            //_students.Add(new Student("Stephanie", "Rajan"));


        }

    } // class

} // namespace
