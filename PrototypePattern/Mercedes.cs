using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    // Concrete implementation of the Prototype
    public class Mercedes : BasicCar
    {
        public Mercedes(string model)
        {
            this.ModelName = model;
        }

        public override BasicCar Clone()
        {
            // MemberwiseClone - Creates a Shallow copy of the casting Object.
            // Copies the non-static fields of the current object to the new object.
            //     If a member is a value type,  a bit-by-bit copy is performed.
            //     If a mamber is a referenced type, the reference is copied, but the
            //         referenced object is not modified, so it's still the same object.

            return (Mercedes)this.MemberwiseClone();
        }
    }
}
