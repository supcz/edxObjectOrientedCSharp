using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab3
{
    class Car
    {
        // constructor - year
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            // increment the count of cars
            instances++;
        }

        // constructor - mileage
        public Car(string color, int year, int mileage)
        {
            this.Color = color;
            this.Year = year;
            this.Mileage = mileage;
            // increment the count of cars
            instances++;
        }
        // private variables
        private static int instances = 0;

        // public methods
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // counter of cars
        public static int CountCars()
        {
            return instances;
        }
    }
}
