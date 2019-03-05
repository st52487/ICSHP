using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Studenti
    {
        public Student[] Students { get; set; }
        private int count = 0;

        public Studenti(int numberOfStudents)
        {
            Students = new Student[numberOfStudents];
        }

        public void addStudent(Student student)
        {
            Students[count++] = student;
        }
    }
}
