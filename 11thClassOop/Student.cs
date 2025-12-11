using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._11thClassOop
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Marks { get; set; }

        public Student(int id, string name, int age, double marks)
        {
            Id = id;
            Name = name;
            Age = age;
            Marks = marks;
        }
    }
}
