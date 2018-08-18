using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class Cat : IAnimal
    {
        public int ID {
            get { return this.ID; }
            set { this.ID = 1;  }
        }

        public void Action()
        {
            Console.WriteLine("I prefers eating mouses...");
        }

        public void Speak()
        {
            Console.WriteLine("Miau Miau!");
        }
    }
}
