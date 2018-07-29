using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating an object of Car() class
            var Car1 = new Car();

            // call members
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            // output to the console window
            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");
        }
    }

    // declaring the Car() class
    // this clas has 3 properties: color, year, mileage
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
