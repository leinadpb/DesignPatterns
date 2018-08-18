using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    // Note: An instance of this class is ONLY created when any of the static methods
    //       are called.

    // sealed keyword: Prevents inheritance.
    public sealed class ServiceEx
    {
        private static  ServiceEx instance = null; // Class instance
        private static int numberOfInstances = 0; // Quanity of instances created
        private static readonly Object teastableObj = new object(); // For lock control

        // Private constructor: Prevents instantiation out of this class.
        private ServiceEx() {
            numberOfInstances++;
        }

        public static ServiceEx Instance { //Getting the instance.

            get {
                if(instance == null)
                {
                    lock (teastableObj) // Allow access to only ONE thread at a time.
                    {
                        instance = new ServiceEx(); // Creates an instance of this class
                    }
                }
                return instance; // return the instance
            }
        }
    }
}
