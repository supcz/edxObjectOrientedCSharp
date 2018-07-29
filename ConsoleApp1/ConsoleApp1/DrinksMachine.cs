using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }

        // definition of private member variables
        private string _model;
        private string _location;
        private string _make;
        static public double _count;

        public string Model { get => _model; set => _model = value; }
        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }

        // definition of public methods
        public void MakeCapuccino()
        {
            Console.WriteLine("Capuccino is made.");
        }
    }
}
