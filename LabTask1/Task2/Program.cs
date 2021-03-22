using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///student part

            var s1 = new Student("Mahfuza", "39398", 3.0F);
            var s2 = new Student("Sharmili ", "19", 3.5F);
            var s3 = new Student("Jui", "1", 3.85F);



            //course part

            var c1 = new Course("CS01", "OOP2");
            var c2 = new Course("CS02", "Compiler Design");
            var c3 = new Course("CS03", "Software Engineering");


            //add and remove part
            c1.AddStudent(s2, s3);

            c1.PrintStudent();

            c1.RemoveStudent(s3);

            Console.WriteLine("\n    After Removing Student  \n");

            s1.PrintCourse();
            c1.PrintStudent();

            Console.WriteLine("\n                   \n");

            s2.AddCourse(c1, c2, c3);
            s2.PrintCourse();

            s2.RemoveCourse(c2);
            Console.WriteLine("\n After Dropping Course \n");
            s2.PrintCourse();
            c2.PrintStudent();
        }
    }
}