using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    //This is the Prototype
    public abstract class BasicCar
    {
        // non-static fields can be copied using: MemberwiseClone() method.
        public string ModelName { get; set; }
        public int Price { get; set; }

        public int SetPrice() {
            Random rand = new Random();
            int p = rand.Next(10000, 15000);
            this.Price = p;
            return this.Price;
        }

        // Cloning Method
        public abstract BasicCar Clone();
    }
}
