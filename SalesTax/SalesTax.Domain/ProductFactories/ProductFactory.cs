using SalesTax.Products;
using System;

namespace SalesTax.ProductFactories
{
    /// <summary>
    /// Factory providing instances of Product .
    /// </summary>
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct(string name, decimal price, bool imported, int quantity);
    }
}
