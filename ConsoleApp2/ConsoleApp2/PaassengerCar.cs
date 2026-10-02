using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class PassengerCar : Car
    {

        private static int counter = 0;
        public int ID2 { get; }
        public PassengerCar()
        {
            counter++;
            ID2 = counter;
            Id = int.Parse("1" + ID2.ToString());
            Console.WriteLine(Id);
        }
        public override int Id { get; }
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override int Year { get; set; }
        public override int Price { get; set; }
        public override int Mileage { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Year:{Year}");
            Console.WriteLine($"Price:{Price}$");
            Console.WriteLine($"Mileage:{Mileage} km");
            Console.WriteLine($"Number Of Doors:{NumberOfDoors}");
            Console.WriteLine($"Fuel Type:{FuelType}");
            Console.WriteLine($"Trunk Capacity:{TrunkCapacity} l");
        }
        public int NumberOfDoors { get; set; }
        public FuelType FuelType { get; set; }
        public int TrunkCapacity { get; set; }
    }
}
