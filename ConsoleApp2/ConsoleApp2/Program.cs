using ConsoleApp2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
int currentYear = DateTime.Now.Year;
string operation;
CarFleet fleet = new CarFleet();
do
{
    Console.Clear();
    Console.WriteLine("===== АВТОПАРК =====");
    Console.WriteLine("1.Додати автомобіль");
    Console.WriteLine("2.Видалити автомобіль");
    Console.WriteLine("3.Переглянути автомобіль");
    Console.WriteLine("4.Переглянути всі автомобілі");
    Console.WriteLine("5.Знайти найдорожчий автомобіль");
    Console.WriteLine("6.Показати середній пробіг");
    Console.WriteLine("7.Знайти автомобілі за маркою");
    Console.WriteLine("8.Сортувати автомобілі");
    Console.WriteLine("0.Вийти");
    Console.WriteLine("Ваш вибір:");

    operation = Console.ReadLine().Trim();
    switch (operation)
    {
        case "1":
            string operation2;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Легковий автомобіль");
                Console.WriteLine("2.Вантажний автомобіль");
                Console.WriteLine("3.Бус");
                Console.WriteLine("0.Назад");
                Console.WriteLine("Ваш вибір");
                operation2 = Console.ReadLine().Trim();
                Console.Clear();
                switch (operation2)
                {
                    case "1":
                        
                        PassengerCar car = new PassengerCar();
                        Console.WriteLine("Введіть назву марки атво");
                        car.Brand = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Введіть назву моделі атво");
                        car.Model = Console.ReadLine();
                        Console.Clear();
                        car.Year = ReadInt("Введіть рік випруску атво", 1950, currentYear);
                        Console.Clear();
                        car.Price = ReadInt("Введіть ціну атво",0,1000000000);
                        Console.Clear();
                        car.Mileage = ReadInt("Введіть пробіг атво в км",0,1000000);
                        Console.Clear();
                        int doors;
                        do
                        {
                            Console.WriteLine("Скільки дверей в автомобілі?");

                            if (!int.TryParse(Console.ReadLine(), out doors))
                            {
                                Console.Clear();
                                Console.WriteLine("Двері вимірюються в числах");
                                continue;
                            }
                            if (doors < 2 || doors > 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Дверей буває від 2 до 4");
                            }
                        } while (doors < 2 || doors > 4);
                        car.NumberOfDoors = doors;
                        Console.Clear();
                        Console.WriteLine("Виберіть тип палива");
                        Console.WriteLine("1.Бензин");
                        Console.WriteLine("2.Дизель");
                        Console.WriteLine("3.Гібрид");
                        Console.WriteLine("4.Електрика");
                        Console.WriteLine("Ваш вибір");
                        int fuelint;
                        do
                        {
                            if (!int.TryParse(Console.ReadLine(), out fuelint))
                            {
                                Console.Clear();
                                Console.WriteLine("Вибери опцыю від 1 до 4");
                                continue;
                            }
                            if (fuelint < 1 || fuelint > 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Тільки від 1 до 4");
                            }
                        } while (fuelint < 1 || fuelint > 4);

                        string fuel = fuelint.ToString();

                        switch (fuel)
                        {
                            case "1":
                                car.FuelType = FuelType.Petrol;
                                break;

                            case "2":
                                car.FuelType = FuelType.Diesel;
                                break;

                            case "3":
                                car.FuelType = FuelType.Hybrid;
                                break;
                            case "4":
                                car.FuelType = FuelType.Electric;
                                break;
                        }
                        Console.Clear();
                        car.TrunkCapacity = ReadInt("Виберіть об'єм багажника",0,1000);
                        fleet.AddCar(car);
                        Console.Clear();
                        operation2 = "0";
                        break;

                    case "2":
                        Bus bus = new Bus();
                        Console.WriteLine("Введіть назву марки атво");
                        bus.Brand = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Введіть назву моделі атво");
                        bus.Model = Console.ReadLine();
                        Console.Clear();
                        bus.Year = ReadInt("Введіть рік випруску атво", 1950, currentYear);
                        Console.Clear();
                        bus.Price = ReadInt("Введіть ціну атво", 0, 1000000000);
                        Console.Clear();
                        bus.Mileage = ReadInt("Введіть пробіг атво в км", 0, 1000000);
                        Console.Clear();
                        int Passengers;
                        do
                        {
                            Console.WriteLine("Скільки пасажирів вміщається в автобус?");

                            if (!int.TryParse(Console.ReadLine(), out Passengers))
                            {
                                Console.WriteLine("пасажири вимірюються в числах");
                                continue;
                            }
                            if (Passengers < 6 || Passengers > 60)
                            {
                                Console.WriteLine("В автобусах поміщається від 6 до 60 людей");
                            }
                        } while (Passengers < 6 || Passengers > 60);
                        bus.PassengerCapacity = Passengers;
                        Console.Clear();
                        int Seats;
                        do
                        {
                            Console.WriteLine("Скільки сидінь в автобус?");

                            if (!int.TryParse(Console.ReadLine(), out Seats))
                            {
                                Console.WriteLine("сидіння вимірються в числах");
                                continue;
                            }
                            if (Seats < 6 || Seats > 60)
                            {
                                Console.WriteLine("В автобусах може бути від 7 до 43 сидінь");
                            }
                        } while (Seats < 7 || Seats > 43);
                        bus.NumberOfSeats = Seats;
                        Console.Clear();
                        Console.WriteLine("Чи є кондиціонер?");
                        Console.WriteLine("1.Так");
                        Console.WriteLine("2.Ні");
                        string condition = Console.ReadLine().Trim();
                        switch (condition)
                        {
                            case "1":
                                bus.HasAirConditioning = true;
                                break;

                            case "2":
                                bus.HasAirConditioning = false;
                                break;

                        }
                        fleet.AddCar(bus);
                        Console.Clear();
                        operation2 = "0";
                        break;
                    case "3":
                        Truck truck = new Truck();
                        Console.WriteLine("Введіть назву марки атво");
                        truck.Brand = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Введіть назву моделі атво");
                        truck.Model = Console.ReadLine();
                        Console.Clear();
                        truck.Year = ReadInt("Введіть рік випруску атво", 1950, currentYear);
                        Console.Clear();
                        truck.Price = ReadInt("Введіть ціну атво", 0, 1000000000);
                        Console.Clear();
                        truck.Mileage = ReadInt("Введіть пробіг атво в км", 0, 1000000);
                        Console.Clear();
                        int Load;
                        do
                        {
                            Console.WriteLine("Яка грузопідйомнітсть?");

                            if (!int.TryParse(Console.ReadLine(), out Load))
                            {
                                Console.Clear();
                                Console.WriteLine("Грузопідйомність вимірюється в числах");
                                continue;
                            }
                            if (Load < 500 || Load > 40000)
                            {
                                Console.Clear();
                                Console.WriteLine("Грузопідйомність може бути від 500 до 40 000 кг");
                            }
                        } while (Load < 500 || Load > 40000);
                        truck.LoadCapacity = Load;
                        Console.Clear();
                        int Axles;
                        do
                        {
                            Console.WriteLine("Скільки осей в вантажівці?");

                            if (!int.TryParse(Console.ReadLine(), out Axles))
                            {
                                Console.Clear();
                                Console.WriteLine("Осі вимірються в числах");
                                continue;
                            }
                            if (Axles < 2 || Axles > 4)
                            {
                                Console.Clear();
                                Console.WriteLine("У грузовика від 2 до 4 осей");
                            }
                        } while (Axles < 2 || Axles > 4);
                        truck.NumberOfAxles = Axles;
                        Console.Clear();
                        Console.WriteLine("Чи є причіп?");
                        Console.WriteLine("1.Так");
                        Console.WriteLine("2.Ні");
                        string Trailer = Console.ReadLine().Trim();

                        switch (Trailer)
                        {
                            case "1":
                                truck.HasTrailer = true;
                                break;

                            case "2":
                                truck.HasTrailer = false;
                                break;

                        }
                        fleet.AddCar(truck);
                        operation2 = "0";
                        break;
                    case "0":
                        break;


                } while (operation2 != "0") ;

                break;

            } while (operation != "0");
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Введіть ID авто");
            fleet.RemoveCar(int.Parse(Console.ReadLine()));
            Console.WriteLine("Натисніть любу клавішу щоб продовжити");
            Console.ReadLine();
            continue;

        case "3":
            Console.Clear();
            Console.WriteLine("Введіть ID авто");
            fleet.GetCar(int.Parse(Console.ReadLine()));
            Console.WriteLine("Натисніть любу клавішу щоб продовжити");
            Console.ReadLine();
            continue;

        case "4":
            Console.Clear();
            fleet.DisplayAllCars();
            Console.WriteLine("Натисніть любу клавішу щоб продовжити");
            Console.ReadLine();
            continue;
        case "5":
            Console.Clear();
            fleet.FindMostExpensiveCar();
            Console.WriteLine("Натисніть любу клавішу щоб продовжити");
            Console.ReadLine();
            continue;
        case "6":
            Console.Clear();
            fleet.GetAverageMileage();
            Console.WriteLine("Натисніть любу клавішу щоб продовжити");
            Console.ReadLine();
            continue;
        case "7":
            Console.Clear();
            Console.WriteLine("Введіть марку авто");
            fleet.FilterByBrand(Console.ReadLine());
            Console.WriteLine("Натисніть любу клавішу щоб продовжити");
            Console.ReadLine();
            continue;
        case "8":
            Console.Clear();
            Console.WriteLine("1.Знайти найновішу машину");
            Console.WriteLine("2.Авто з пробігом менше ніж");
            Console.WriteLine("3.Пасажирьскі авто");
            Console.WriteLine("4.Автобуси");
            Console.WriteLine("5.Вантажівки");
            Console.WriteLine("0.Назад");
            string operation3 = Console.ReadLine().Trim();
            switch (operation3)
            {
                case "1":
                    fleet.FindNewestCar();
                    continue;
                case "2":
                    Console.WriteLine("Введіть максимальний пробіг");
                    fleet.GetCarsWithMileageLessThan(int.Parse(Console.ReadLine()));
                    continue;
                case "3":
                    fleet.GetPassengerCars();
                    continue;
                case "4":
                    fleet.GetBuses();
                    continue;
                case "5":
                    fleet.GetTrucks();
                    continue;
                case "0":
                    break;
            }
            continue;

    }

} while (operation != "0");
Console.Clear();
Console.WriteLine("Good bye");



static int ReadInt(string message,int min, int max)
{
    int value;
    do
    {
        Console.WriteLine(message);
        if (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Введіть число");
            continue;
        }

        if (value < min || value > max)
        {
            Console.WriteLine("Число в діапазоні від " + min + " до " + max);
            continue;
        }
        return value;

    } while (true);
}




