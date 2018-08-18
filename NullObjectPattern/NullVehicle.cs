using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class NullVehicle : IVehicle
    {

        private static readonly NullVehicle instance = new NullVehicle();
        public static int NullVehicleCount = 0;

        public static NullVehicle Instance
        {
            get
            {
                return instance;
            }
        }


        public void Travel()
        {
            // Nothing
        }
    }
}
