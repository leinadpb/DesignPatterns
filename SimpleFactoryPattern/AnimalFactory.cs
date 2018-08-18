using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal Animal = null;

        public override IAnimal CreateAnimal(int ai)
        {
            switch (ai)
            {
                case 1: // Creates a Dog
                    Animal = new Dog();
                    break;
                case 2:
                    Animal = new Cat();
                    break;
                default:
                    throw new ApplicationException(String.Format("Unknown Animal cannot be instantiated."));
            }
            return Animal;
        }
    }
}
