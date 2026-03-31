using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Anna";
            Student student2 = new Student();
            student2.Name = "Eva";
            Student.Group = "223 SIS";
            Console.WriteLine(student.Name + " " + Student.Group); 
            Console.WriteLine(student2.Name + " " + Student.Group);
        }
        class Student
        {
            public string Name;
            public int Age;
            public static string Group;
        }
    }
}
