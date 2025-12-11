using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._11thClassOop
{
    internal class StudentManager
    {
        // List to store multiple student objects
        private List<Student> students = new List<Student>();

        // Add function
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // List function
        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
