using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class Ship : IVehicle
    {
        public static int ShipCount { get; set; }

        public Ship()
        {
            ShipCount++;
        }

        public void Travel()
        {
            Console.WriteLine("Let us travel with Ship!");
        }
    }
}
