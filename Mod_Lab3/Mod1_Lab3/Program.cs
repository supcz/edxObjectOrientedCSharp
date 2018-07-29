using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab3
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
}
