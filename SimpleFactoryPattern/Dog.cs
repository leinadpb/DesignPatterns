using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public int ID
        {
            get { return this.ID; }
            set { this.ID = 2; }
        }

        public void Action()
        {
            Console.WriteLine("I prefer eating cats...");
        }

        public void Speak()
        {
            Console.WriteLine("Wuuf wuf!");
        }
    }
}
