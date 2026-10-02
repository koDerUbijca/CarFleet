using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Truck : Car
    {

        private static int counter = 0;
        public int ID2 { get; }
        public Truck()
        {
            counter++;
            ID2 = counter;
            Id = int.Parse("3" + ID2.ToString());
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
            Console.WriteLine($"Load Capacity:{LoadCapacity} kg");
            Console.WriteLine($"Number Of Axles:{NumberOfAxles}");
            Console.WriteLine($"Trailer:{HasTrailer}");
        }
        public int LoadCapacity { get; set; }
        public int NumberOfAxles { get; set; }
        public bool HasTrailer { get; set; }
    }
}
