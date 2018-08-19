using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class CatFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
}
