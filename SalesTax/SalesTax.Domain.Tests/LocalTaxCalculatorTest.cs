using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.Billing;
using SalesTax.TaxCalculations;

namespace SalesTax.DomainTests
{
    [TestClass]
    public class LocalTaxCalculatorTest
    {

        private Biller biller;
        private string country;
        ITaxCalculator taxCal;

        void Initialize()
        {
            country = "Local";
            TaxCalculatorFactory factory = new TaxCalculatorFactory();
            taxCal = factory.GetTaxCalculator(country);
            biller = new Biller(taxCal);

        }
            
        
        [TestMethod]
        public void CalculateTaxTest()
        {
            Initialize();
            decimal totalProductTax = taxCal.CalculateTax(12.49M,0, false);
            Assert.AreEqual(0, 0);

        }
    }
}
