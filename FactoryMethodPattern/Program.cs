using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Factory Method Pattern Implementation -----");
            Console.WriteLine("");

            IAnimalFactory FactoryDog = new DogFactory();
            IAnimal animal = FactoryDog.MakeAnimal();
            //animal.Speak();
            //animal.Action();

            Console.WriteLine("");
            IAnimalFactory FactoryCat = new CatFactory();
            animal = FactoryCat.MakeAnimal();
            //animal.Speak();
            //animal.Action();

            Console.Read();
        }
    }
}
