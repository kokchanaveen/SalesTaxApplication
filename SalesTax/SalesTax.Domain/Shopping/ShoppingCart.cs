using SalesTax.Products;
using System.Collections.Generic;

namespace SalesTax.Shopping
{
    /// <summary>
    /// Represents the shoppingcart containing the products.
    /// </summary>
    public class ShoppingCart
    {
        private List<Product> productList { get; set; }

        public ShoppingCart()
        {
            productList = new List<Product>();
        }

        public void AddItemToCart(Product product)
        {
            productList.Add(product);
        }

        public List<Product> GetItemsFromCart()
        {
            return productList;
        }
        public void ResetCart()
        {
            productList.Clear();
        }

        public int GetCartSize()
        {
            return productList.Count;
        }
    }
}
