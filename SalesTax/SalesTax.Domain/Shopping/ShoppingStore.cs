using SalesTax.Billing;
using SalesTax.Products;
using SalesTax.utils;
using System;

namespace SalesTax.Shopping
{
    /// <summary>
    /// Represents the virtual store
    /// </summary>
    public class ShoppingStore
    {
        private ShoppingCart shoppingCart;
        private StoreShelf storeShelf;
        private PaymentCounter paymentCounter;
        private string country;

        public ShoppingStore()
        {
            country = "Local";
            shoppingCart = new ShoppingCart();
            paymentCounter = new PaymentCounter(country);
            storeShelf = new StoreShelf();
        }

        public void RetrieveOrderAndPlaceInCart(string name, decimal price, bool imported, int quantity)
        {
            Product product = storeShelf.SearchAndRetrieveItemFromShelf(name, price, imported, quantity);
            shoppingCart.AddItemToCart(product);
        }

        public void GetSalesOrder()
        {
           //Order1
           RetrieveOrderAndPlaceInCart("book", 12.49M, false, 1);
           RetrieveOrderAndPlaceInCart("music cd", 14.99M, false, 1);
           RetrieveOrderAndPlaceInCart("chocolate bar", 0.85M, false, 1);
           Console.WriteLine("Output 1:"+Environment.NewLine);
           CheckOut();

            //Order2
            RetrieveOrderAndPlaceInCart("box of chocolates", 10.00M, true, 1);
            RetrieveOrderAndPlaceInCart("bottle of perfume", 47.50M, true, 1);
            Console.WriteLine("Output 2:" + Environment.NewLine);
            CheckOut();

            //Order3
            RetrieveOrderAndPlaceInCart("bottle of perfume", 27.99M, true, 1);
            RetrieveOrderAndPlaceInCart("bottle of perfume", 18.99M, false, 1);
            RetrieveOrderAndPlaceInCart("packet of headache pills", 9.75M, false, 1);
            RetrieveOrderAndPlaceInCart("box of chocolates", 11.25M, true, 1);
            Console.WriteLine("Output 3:" + Environment.NewLine);
            CheckOut();
        }

        public void CheckOut()
        {
            paymentCounter.BillItemsInCart(shoppingCart);
            Receipt receipt = paymentCounter.GetReceipt();
            paymentCounter.PrintReceipt(receipt);
            shoppingCart.ResetCart();
        }

              
    }
}
