using SalesTax.utils;

namespace SalesTax.TaxCalculations
{
    /// <summary>
    /// It Calculates Total Tax Cost According to Local Region Specification.
    /// </summary>
    public class LocalTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal price, decimal localTax, bool imported)
        {
            decimal tax = price * localTax;

            if (imported)
                tax += (price * 0.05M);

            //rounds off to nearest 0.05;
            tax = TaxUtil.RoundOff(tax);

            return tax;
        }
    }
}
