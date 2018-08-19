using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Builder Pattern Implementation -----");
            Console.WriteLine();

            IBuilder builder1 = new Car("Honda");
            IBuilder builer2 = new Jeep("Toyota");

            Director director = new Director();

            director.Construct(builder1); //Construct the car
            var car = builder1.GetProduct(); //Get the new constructed car
            car.Show(); //Show the new created car

            director.Construct(builer2); //Construct the jeep
            var jeep = builer2.GetProduct(); //Get the new created jeep
            jeep.Show(); //Show the new created jeep

            Console.Read();
        }
    }
}
