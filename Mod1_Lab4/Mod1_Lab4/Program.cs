using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // number of allocated students is 200 - how to make an unknown length array
            Student[] students = new Student[200];
            students[Student.CountStudents()] = new Student("Marek", "Soukup", "marek.soukup@principal.cz");
            students[Student.CountStudents()] = new Student("Jana", "Čermáková", "jana.cermakova@volny.cz");


            Console.WriteLine(Student.CountStudents());
            // print every value of array to console
            for (int loop = 0; loop < Student.CountStudents(); loop++)
            {
                Console.WriteLine($"Student number {loop+1} is {students[loop].FirstName} {students[loop].LastName} and e-mail is {students[loop].Email}");
            }

        }
    }
}


