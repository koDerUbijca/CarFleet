using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Bus : Car
    {

        private static int counter = 0;
        public int ID2 { get; }
        public Bus()
        {
            counter++;
            ID2 = counter;
            Id = int.Parse("2" + ID2.ToString());
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
            Console.WriteLine($"Passenger Capacity:{PassengerCapacity}");
            Console.WriteLine($"Number Of Seats:{NumberOfSeats}");
            Console.WriteLine($"AirConditioning:{HasAirConditioning}");
        }
        public int PassengerCapacity { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasAirConditioning { get; set; }
    }
    
}
