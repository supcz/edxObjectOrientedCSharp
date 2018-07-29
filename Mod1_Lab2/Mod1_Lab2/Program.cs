using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create red car
            Car redCar = new Car("Red", 2015);

            // create blue car
            Car blueCar = new Car("Blue", 2010);

            // create green car
            Car greenCar = new Car("Green", 2005, 220000);

            int carCount = Car.CountCars();

            Console.WriteLine($"{redCar.Color} car was built in {redCar.Year}");
            Console.WriteLine($"{blueCar.Color} car was built in {blueCar.Year}");
            Console.WriteLine($"{greenCar.Color} car was built in {greenCar.Year}");
            Console.WriteLine($"There are {carCount} cars in your inventory right now");
        }
    }

    // class Car
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
