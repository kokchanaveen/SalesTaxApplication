using SalesTax.ProductFactories;
using SalesTax.TaxCalculations;
using System;

namespace SalesTax.Products
{
    /// <summary>
    ///  Represents Book product type.
    /// </summary>
    public class BookProduct : Product
    {

        public BookProduct()
            : base()
        {
        }

        public BookProduct(string name, decimal price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {

        }

        public override ProductFactory GetFactory()
        {
            return new BookProductFactory();
        }

        public override decimal GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.BOOK_TAX;
            else
                return 0;
        }
    }
}
