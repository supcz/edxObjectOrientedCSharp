using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab4
{
    class Student
    {
        // constructor
        public Student(string firstName, string lastName, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = eMail;
            // incerement number of students
            studentsCount++;
        }

        // private variables
        private static int studentsCount = 0;

        // public methods
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // return number of instances
        public static int CountStudents()
        {
            return studentsCount;
        }
    }
}
