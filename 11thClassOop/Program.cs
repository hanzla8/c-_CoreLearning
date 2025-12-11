using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._11thClassOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create manager & display objects
            StudentManager manager = new StudentManager();
            DisplayService display = new DisplayService();

            // Create multiple students (objects)
            Student s1 = new Student(1, "Ali", 20, 89.5);
            Student s2 = new Student(2, "Hanzla", 22, 91.3);
            Student s3 = new Student(3, "Hamza", 19, 95.9);

            // Add students
            manager.AddStudent(s1);
            manager.AddStudent(s2);
            manager.AddStudent(s3);

            // Display students
            display.ShowStudents(manager.GetAllStudents());
        }
    }
}
