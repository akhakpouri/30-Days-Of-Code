using System;

namespace FactoryPattern.Models
{
    public abstract class Product : IProduct
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public ProductType ProductType { get; set; }
        public void Allign()
        {
            Console.WriteLine($"{nameof(IProduct)} is about to get alligned.");
        }
        public void Cut()
        {
            Console.WriteLine($"{nameof(IProduct)} is about to get cut.");
        }

        protected Product()
        {

        }
    }
}
