namespace SalesTax.ProductFactories
{
    /// <summary>
    /// Represents Book product factory.
    /// </summary>
    public class BookProductFactory : ProductFactory
    {
        public override Products.Product CreateProduct(string name, decimal price, bool imported, int quantity)
        {
            return new Products.BookProduct(name, price, imported, quantity);
        }
    }
}
