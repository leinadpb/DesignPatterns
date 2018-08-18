using System;
using System.Collections.Generic;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Simple Factory Design Pattern -----");
            Console.WriteLine("Factory class: AnimalFactory");
            Console.WriteLine("");

            AnimalFactory Factory = new AnimalFactory();
            IAnimal PreferedAnimal = null;

            #region Code that may vary based in user preference
            PreferedAnimal = Factory.CreateAnimal(1);       // Creates a Dog
            //PreferedAnimal = Factory.CreateAnimal(2);    // Creates a Cat
            //IAnimal Snake = Factory.CreateAnimal(3);    // It will throw an exception
            #endregion

            #region Code that is less likely to change.
            PreferedAnimal.Action();
            PreferedAnimal.Speak();
            #endregion

            Console.Read();
        }
    }
}
