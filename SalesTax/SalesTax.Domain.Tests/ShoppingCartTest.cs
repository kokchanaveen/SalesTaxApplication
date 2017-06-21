using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.Products;
using SalesTax.Shopping;

namespace SalesTax.DomainTests
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void AddItemToCartTest()
        {
            var storeShelf = new StoreShelf();
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddItemToCart(storeShelf.SearchAndRetrieveItemFromShelf("book", 12.49M, false, 1));
            Assert.IsNotNull(shoppingCart.GetItemsFromCart());


        }

        [TestMethod]
        public void GetItemsFromCartTest()
        {
            var storeShelf = new StoreShelf();
            var shoppingCart = new ShoppingCart();
            Product product = storeShelf.SearchAndRetrieveItemFromShelf("book", 12.49M, false, 1);
            shoppingCart.AddItemToCart(product);
            Assert.IsNotNull(shoppingCart.GetItemsFromCart());


        }
    }
}
