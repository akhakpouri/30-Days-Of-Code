using FactoryPattern.Models;

namespace FactoryPattern.Factories
{
    public abstract class ProductFactory : IProductFactory
    {
        public abstract IProduct CreateProduct();
    }
}
