using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class CarFleet
    {
        private List<Car> cars = new List<Car>();
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RemoveCar(int ID)
        {
            foreach (Car car in cars)
            {
                if (car.Id == ID)
                {
                    cars.Remove(car);
                    Console.WriteLine("Машина з ID " + ID + " видалина з автопарку");
                }

            }
            Console.WriteLine("Машини з таким ID не існує");

        }
        public Car GetCar(int id)
        {
            foreach (Car car in cars)
            {
                if (car.Id == id)
                {
                    car.DisplayInfo();
                    return car;
                }

            }
            Console.WriteLine("Машини з таким ID не існує");
            return null;
        }
        public void DisplayAllCars()
        {
            foreach (Car car in cars)
            {
                car.DisplayInfo();
            }
        }
        public void FindMostExpensiveCar()
        {
            int id2 = 0;
            int maxprice = 0;
            foreach (Car car in cars)
            {
                if (car.Price > maxprice)
                {
                    maxprice = car.Price;
                    id2 = car.Id;
                }

            }
            Console.WriteLine("Ціна найдорожчої машини- " + maxprice);
            GetCar(id2);

        }
        public void GetAverageMileage()
        {
            int sum = 0;
            int count = 0;
            foreach (Car car in cars)
            {
                sum = +car.Mileage;
                count++;
            }
            sum = sum / count;
            Console.WriteLine("Середній пробіг = " + sum);
        }
        public void FilterByBrand(string term) // терм змынна коли е пошуковий запит
        {
            var filteredcars = cars.Where(x => x.Brand == term);
            foreach (Car car in filteredcars)
            {
                car.DisplayInfo();
            }
        }
        public void FindNewestCar()
        {
            Car youngestCar = cars.OrderByDescending(x => x.Year).FirstOrDefault();
            Console.WriteLine("Сама нова машина це:");
            youngestCar.DisplayInfo();

        }
        public void GetCarsWithMileageLessThan(int mileage)
        {
            foreach (Car car in cars)
            {
                if (car.Mileage < mileage)
                {
                    car.DisplayInfo();
                }
            }
        }
        public void GetPassengerCars()
        {
            foreach (PassengerCar car in cars)
            {
                car.DisplayInfo();
            }
        }
        public void GetBuses()
        {
            foreach (Bus car in cars)
            {
                car.DisplayInfo();
            }
        }
        public void GetTrucks()
        {
            foreach (Truck car in cars)
            {
                car.DisplayInfo();
            }
        }
    }
}
//int sum = cars.Sum(x => x.Mileage);
//int count = cars.Count;
//sum = sum / count;
//Console.WriteLine("Середній пробіг = " + sum);
//FindNewestCar()
//GetCarsWithMileageLessThan(int mileage)
//GetTotalValue()
//GetPassengerCars()
//GetBuses()
//GetTrucks()