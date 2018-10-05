using FactoryPattern.Models;
using FactoryPattern.Models.Products;

namespace FactoryPattern.Factories
{
    class ToolsFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return new WorkTools();
        }
    }
}
