using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Prototype Pattern Implementation -----");
            Console.WriteLine("Prototype: BasicCat /t Concrete classes: Mercedes, Toyota");
            Console.WriteLine("");

            //Original Copies
            BasicCar MercedesOriginal = new Mercedes("MERCEDES") { Price = 49500 };
            BasicCar ToyotaOriginal = new Toyota("TOYOTA") { Price = 27800 };

            //Show values of Originals
            Console.WriteLine($"MERCEDES\n Model: {MercedesOriginal.ModelName}\n PRICE: {MercedesOriginal.Price}");
            Console.WriteLine($"TOYOTA\n Model: {ToyotaOriginal.ModelName}\n PRICE: {ToyotaOriginal.Price}");

            Console.WriteLine("");
            //Copies
            BasicCar MercedesCopy = MercedesOriginal.Clone();
            MercedesCopy.Price = MercedesCopy.Price + 1211; // Ex: Modify a field
            BasicCar ToyotaCopy = ToyotaOriginal.Clone();
            ToyotaCopy.Price = ToyotaCopy.Price + 851; // Ex: Modify a field

            //Show values of Copies
            Console.WriteLine($"MERCEDES\n Model: {MercedesCopy.ModelName}\n PRICE: {MercedesCopy.Price}");
            Console.WriteLine($"TOYOTA\n Model: {ToyotaCopy.ModelName}\n PRICE: {ToyotaCopy.Price}");

            if(MercedesOriginal != MercedesCopy && ToyotaOriginal != ToyotaCopy)
            {
                Console.WriteLine("\n Prototype Design Pattern implemented successfully!\n");
            }

            Console.Read();
        }
    }
}
