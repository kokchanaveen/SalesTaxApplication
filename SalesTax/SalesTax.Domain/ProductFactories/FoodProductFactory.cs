using SalesTax.Products;

namespace SalesTax.ProductFactories
{
    /// <summary>
    /// Represents Food product factory.
    /// </summary>
    public class FoodProductFactory : ProductFactory
    {
        public override Products.Product CreateProduct(string name, decimal price, bool imported, int quantity)
        {
            return new FoodProduct(name, price, imported, quantity);
        }
    }
}
