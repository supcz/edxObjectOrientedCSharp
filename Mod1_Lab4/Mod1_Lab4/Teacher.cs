using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab4
{
    class Teacher
    {
        // constructor
        public Teacher(string firstName, string lastName, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = eMail;
        }

        // public methods
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
