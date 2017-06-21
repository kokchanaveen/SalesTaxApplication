using SalesTax.Products;

namespace SalesTax.ProductFactories
{

    /// <summary>
    /// Represents Medical product factory.
    /// </summary>
    public class MedicalProductFactory : ProductFactory
    {
        public override Products.Product CreateProduct(string name, decimal price, bool imported, int quantity)
        {
            return new MedicalProduct(name, price, imported, quantity);
        }
    }
}
