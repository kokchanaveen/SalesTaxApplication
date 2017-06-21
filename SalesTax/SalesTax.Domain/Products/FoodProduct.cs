using SalesTax.ProductFactories;
using SalesTax.TaxCalculations;
using System;

namespace SalesTax.Products
{ /// <summary>
  ///  Represents Food product type.
  /// </summary>
    public class FoodProduct : Product
    {
        public FoodProduct()
            : base()
        {

        }

        public FoodProduct(string name, decimal price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }

        public override ProductFactory GetFactory()
        {
            return new FoodProductFactory();
        }

        public override decimal GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.FOOD_TAX;
            else
                return 0;
        }
    }
}
