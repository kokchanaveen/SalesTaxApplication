using SalesTax.Products;

namespace SalesTax.ProductFactories
{
    /// <summary>
    /// Factory placeholder for all other product types.
    /// </summary>
    public class MiscellaneousProductFactory : ProductFactory
    {
        public override Products.Product CreateProduct(string name, decimal price, bool imported, int quantity)
        {
            return new MiscellaneousProduct(name, price, imported, quantity);
        }
    }
}
