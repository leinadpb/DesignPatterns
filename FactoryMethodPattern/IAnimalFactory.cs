using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class IAnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("Making animal depending of the subclasses! - Factory Method Working!");
            // It doesn't know if it's going to create a dog or a cat.
            // It will be decided by the subclasses
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();

            return animal;
        }
       
        //This method is acting like Factory of Creating
        public abstract IAnimal CreateAnimal();
    }
}
