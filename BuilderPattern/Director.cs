using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    // This entity is responsible for creating the complex object using the Builder already constructed.
    public class Director
    {
        IBuilder builder;

        public void Construct(IBuilder newBuilder)
        {
            builder = newBuilder;
            newBuilder.StartUpOperations();
            newBuilder.BuildBody();
            newBuilder.InsertWheels();
            newBuilder.EndOperations();
        }
    }
}
