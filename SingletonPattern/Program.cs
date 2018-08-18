using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string singletonClass = "ServicesEx";
            Console.WriteLine("----- Singleton Pattern Implementation -----");
            Console.WriteLine($"Singleton class: {singletonClass}");
            Console.WriteLine("");

            ServiceEx singleton1 = ServiceEx.Instance;
            ServiceEx singleton2 = ServiceEx.Instance;

            if(singleton1 == singleton2)
            {
                Console.WriteLine("Singleton Pattern Implemented Successfully!");
            }

            Console.Read();
        }
    }
}
