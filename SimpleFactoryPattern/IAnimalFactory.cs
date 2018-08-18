using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public abstract class IAnimalFactory
    {
        public abstract IAnimal CreateAnimal(int id);

    }
}
