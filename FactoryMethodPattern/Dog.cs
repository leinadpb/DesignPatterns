using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Eating cats...");
        }

        public void Speak()
        {
            Console.WriteLine("Wouf wouf!");
        }
    }
}
