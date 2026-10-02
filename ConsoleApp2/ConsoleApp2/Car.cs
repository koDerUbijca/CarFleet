using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class Car
    {
        public abstract int Id { get; } //ctrl+R+R перейминувати все зхразу, в абривіатурі тільки перша буква велика
        public abstract string Brand { get; set; }
        public abstract string Model { get; set; }
        public abstract int Year { get; set; }
        public abstract int Price { get; set; }
        public abstract int Mileage { get; set; }
        public abstract void DisplayInfo();
    }
}
