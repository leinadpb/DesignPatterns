using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    // Complex product
    public class Product
    {
        public LinkedList<string> _Parts;

        public Product()
        {
            _Parts = new LinkedList<string>();
        }

        public void Add(string property)
        {
            _Parts.AddLast(property);
        }

        public void Show()
        {
            Console.WriteLine("\nShowing product ------");
            int Count = 1;
            foreach(var str in _Parts)
            {
                Console.WriteLine($"{Count}) {str}");
                Count++;
            }
        }

    }
}
