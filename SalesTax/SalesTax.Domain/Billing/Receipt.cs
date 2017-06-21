using SalesTax.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Billing
{
    /// <summary>
    /// Generates receipts based on purchases made
    /// </summary>
    public class Receipt
    {
        private List<Product> ProductList { get; set; }
        private decimal TotalSalesTax { get; set; }
        private decimal TotalAmount { get; set; }

        public Receipt(List<Product> prod, decimal tax, decimal amount)
        {
            ProductList = prod;
            TotalSalesTax = tax;
            TotalAmount = amount;
        }

        public int GetTotalNumberOfItems()
        {
            return ProductList.Count;
        }

        public override string ToString()
        {
            string receipt = "";
            
            foreach (var p in ProductList)
            {
                receipt += (p.ToString() + "\n");
            }

            receipt += "Sales Taxes:" + TotalSalesTax.ToString("F") + "\n";
            receipt += "Total:" + TotalAmount + "\n";

            return receipt;
        }
    }
}
