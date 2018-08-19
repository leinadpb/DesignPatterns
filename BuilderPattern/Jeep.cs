using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Jeep : IBuilder
    {
        private string brandName;
        private Product product;

        public Jeep(string bname)
        {
            this.brandName = bname;
            this.product = new Product();
        }

        public void BuildBody()
        {
            this.product.Add("Adding body - for a jeep.");
        }

        public void EndOperations()
        {
            this.product.Add("Adding finals operations - for a jeep.");
        }

        public Product GetProduct()
        {
            return this.product;
        }

        public void InsertWheels()
        {
            this.product.Add("Insert 4 wheels - for a jeep.");
        }

        public void StartUpOperations()
        {
            this.product.Add("Initialize start up operations - for a jeep.");
        }
    }
}
