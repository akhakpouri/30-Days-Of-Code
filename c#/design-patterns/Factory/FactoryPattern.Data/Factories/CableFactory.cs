using FactoryPattern.Models;
using FactoryPattern.Models.Products;

namespace FactoryPattern.Factories
{
    public class CableFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Cable();
        }
    }
}