using System;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----- Null Object Desing Pattern Implementation -----");
            Console.WriteLine("");

            int totalObjs = 0;
            string input = String.Empty;

            while (!input.Equals("exit"))
            {
                Console.WriteLine("Enter your choice (Type 'a' for Plane, 'b' for Ship, 'exit' to quit): ");
                input = Console.ReadLine();

                IVehicle vehicle = null;

                switch (input)
                {
                    case "a":
                        vehicle = new Plane();
                        break;
                    case "b":
                        vehicle = new Ship();
                        break;
                    case "exit":
                        vehicle = NullVehicle.Instance;
                        Console.WriteLine("Exit application...");
                        break;
                    default:
                        vehicle = NullVehicle.Instance;
                        if (input.Equals("exit"))
                        {
                            Console.WriteLine("Closing app.");
                        }
                        break;
                }
                vehicle.Travel();
                totalObjs = Ship.ShipCount + Plane.PlaneCount + NullVehicle.NullVehicleCount;
                Console.WriteLine($"Total objects created: {totalObjs}");
            }
            Console.Read();
        }
    }
}
