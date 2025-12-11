using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._11thClassOop
{
    internal class DisplayService
    {
        public void ShowStudents(List<Student> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Marks: {s.Marks}");
            }
        }
    }
}
