using SalesTax.ProductFactories;
using SalesTax.TaxCalculations;
using System;

namespace SalesTax.Products
{
    /// <summary>
    ///  Represents Medical product type.
    /// </summary>
    public class MedicalProduct : Product
    {

        public MedicalProduct()
            : base()
        {

        }

        public MedicalProduct(string name, decimal price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }

        public override ProductFactory GetFactory()
        {
            return new MedicalProductFactory();
        }

        public override decimal GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.MEDICAL_TAX;
            else
                return 0;
        }
    }
}
