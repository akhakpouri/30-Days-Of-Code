namespace FactoryPattern.Models
{
    public interface IProduct
    {
        ProductType ProductType { get; set; }
        void Allign();
        void Cut();
    }
}
