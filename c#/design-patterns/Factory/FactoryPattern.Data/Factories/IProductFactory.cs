using FactoryPattern.Models;

namespace FactoryPattern.Factories
{
    public interface IProductFactory
    {
        IProduct CreateProduct();
    }
}
