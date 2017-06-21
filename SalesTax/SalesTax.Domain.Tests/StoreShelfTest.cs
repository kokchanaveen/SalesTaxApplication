using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.Shopping;

namespace SalesTax.DomainTests
{
    [TestClass]
    public class StoreShelfTest
    {
        [TestMethod]
        public void SearchAndRetrieveItemFromShelfTest()
        {
            var objShelf = new StoreShelf();
            var product = objShelf.SearchAndRetrieveItemFromShelf("book", 12.49M, false, 1);
            Assert.IsNotNull(product);

        }

    }
}
