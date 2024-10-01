using static System.Console;
using System.Collections.Generic;

namespace DemoSomeDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu Demo Factory, Abstract, Prototype");
                Console.WriteLine("1. Demo Factory");
                Console.WriteLine("2. Demo Abstract");
                Console.WriteLine("3. Demo Prototype");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("*** Factory Method Pattern Demo ***");
                        List<AnimalFactory> animalList = new List<AnimalFactory>()
                        {
                            new TigerFactory(),
                            new LionFactory()
                        };
                        foreach (var animal in animalList)
                        {
                            animal.CreateAnimal().AboutMe();    
                        }
                        ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("*** Abstract Method Pattern Demo ***");
                        IOrderFactory domesticFactory = new DomesticOrderFactory();
                        IOrder domesticOrder = domesticFactory.CreateOrder();
                        IPayment domesticPayment = domesticFactory.CreatePayment();
                        IShipping domesticShipping = domesticFactory.CreateShipping();

                        domesticOrder.ProcessOrder();
                        domesticPayment.ProcessPayment();
                        domesticShipping.ShipOrder();
                        ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("*** Prototype Method Pattern Demo ***");
                        Car mustang = new Mustang("Mustang EcoBoost");
                        Car bentley = new Bentley("Continental GT Mulliner");
                        Console.WriteLine($"Car is: {mustang.ModelName}, Base Price: {mustang.BasePrice}");
                        Console.WriteLine($"Car is: {bentley.ModelName}, Base Price: {bentley.BasePrice}");
                        ReadLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
