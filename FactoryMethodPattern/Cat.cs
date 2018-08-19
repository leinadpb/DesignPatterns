using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class Cat : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Eating mouses...");
        }

        public void Speak()
        {
            Console.WriteLine("Miau miau!");
        }
    }
}
