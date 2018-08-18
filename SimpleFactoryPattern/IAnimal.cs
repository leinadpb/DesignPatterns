using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public interface IAnimal
    {
        int ID {
            set;
            get;
        }
        void Speak();
        void Action();
    }
}
