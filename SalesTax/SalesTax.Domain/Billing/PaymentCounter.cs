using SalesTax.Products;
using SalesTax.Shopping;
using SalesTax.TaxCalculations;
using System;
using System.Collections.Generic;

namespace SalesTax.Billing
{
    /// <summary>
    /// Represents a virtual counter for payment and invoice
    /// </summary>
    public class PaymentCounter
    {
        private Biller biller;
        private Receipt receipt;
        private List<Product> productList;
        private string country;

        public PaymentCounter(string country)
        {
            this.country = country;
        }

        public void BillItemsInCart(ShoppingCart cart)
        {
            productList = cart.GetItemsFromCart();

            foreach (Product p in productList)
            {
                biller = GetBiller(country);
                decimal productTax = biller.CalculateTax(p.Price, p.GetTaxValue(country), p.Imported);
                decimal taxedCost = biller.CalcTotalProductCost(p.Price, productTax);
                p.TaxedCost = taxedCost;
            }
        }

        public Receipt GetReceipt()
        {
            decimal totalTax = biller.CalcTotalTax(productList);
            decimal totalAmount = biller.CalcTotalAmount(productList);
            receipt = biller.CreateNewReceipt(productList, totalTax, totalAmount);
            return receipt;
        }

        public void PrintReceipt(Receipt receipt)
        {
            biller.GenerateReceipt(receipt);
        }

        public Biller GetBiller(string strategy)
        {
            TaxCalculatorFactory factory = new TaxCalculatorFactory();
            ITaxCalculator taxCal = factory.GetTaxCalculator(strategy);
            return new Biller(taxCal);
        }
    }
}
