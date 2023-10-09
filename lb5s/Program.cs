class Program
{
    static void Main(string[] args)
    {
        List<BaseInform> transports = new List<BaseInform>();

        Random random = new Random();

        transports.Add(new Trolleybus
        {
            TransportType = "Троллейбус",
            Capacity = 100,
            YearOfManufacture = 2020,
            Manufacturer = "Some Manufacturer",
            Price = random.Next(100, 200), 
            Voltage = 750,
            PowerSupply = "Электричество",
            RouteNumber = "123"
        });

        transports.Add(new Bus
        {
            TransportType = "Автобус",
            Capacity = 50,
            YearOfManufacture = 2019,
            Manufacturer = "Another Manufacturer",
            Price = random.Next(80, 150), 
            SeatingCapacity = random.Next(20, 40), 
            StandingCapacity = random.Next(5, 15), 
            AirConditioning = random.Next(0, 2) == 1 
        });

        transports.Add(new Tram
        {
            TransportType = "Трамвай",
            Capacity = 150,
            YearOfManufacture = 2018,
            Manufacturer = "Tram Manufacturer",
            Price = random.Next(120, 250), 
            NumberOfWagons = 3,
            LowFloor = true,
            Route = "456"
        }); 

        
        foreach (var transport in transports)
        {
            Console.WriteLine(transport.ToString());
        }


        if (transports.Count > 0)
        {
            

            int randomIndex = random.Next(transports.Count); 
            BaseInform randomTransport = transports[randomIndex];

           
            randomTransport.Price = random.Next(100, 200); 

            Console.WriteLine($"\nИзмененная цена {randomTransport.TransportType} (элемент с индексом {randomIndex}):");
            Console.WriteLine(randomTransport.ToString());
        }


        if (transports.Count > 0)
        {
            
            int randomIndex = random.Next(transports.Count); 

            Console.WriteLine($"\nУдален элемент с индексом {randomIndex}:");
            Console.WriteLine(transports[randomIndex].ToString());

            transports.RemoveAt(randomIndex); 
        }
        else
        {
            Console.WriteLine("\nСписок пуст, невозможно удалить элемент.");
        }


        Console.WriteLine("\nСодержимое массива после удаления элемента:");
        foreach (var transport in transports)
        {
            Console.WriteLine(transport.ToString());
        }

        Console.ReadKey();
    }
}