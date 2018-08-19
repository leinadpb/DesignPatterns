using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void EndOperations();
        Product GetProduct();
    }
}
