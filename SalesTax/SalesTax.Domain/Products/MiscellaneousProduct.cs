using SalesTax.ProductFactories;
using SalesTax.TaxCalculations;
using System;

namespace SalesTax.Products
{
    /// <summary>
    ///  Placeholder for all other product types.
    /// </summary>
    public class MiscellaneousProduct : Product
    {
        public MiscellaneousProduct()
            : base()
        {
        }
        public MiscellaneousProduct(string name, decimal price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }
        public override ProductFactory GetFactory()
        {
            return new MiscellaneousProductFactory();
        }

        public override decimal GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.MISC_TAX;
            else
                return 0;
        }
    }
}
