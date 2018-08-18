using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class Plane : IVehicle
    {
        public static int PlaneCount { get; set; }

        public Plane()
        {
            PlaneCount++;
        }

        public void Travel()
        {
            Console.WriteLine("Let us travel with Plane!");
        }
    }
}
