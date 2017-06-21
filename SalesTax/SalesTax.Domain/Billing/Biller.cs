using SalesTax.Products;
using SalesTax.TaxCalculations;
using SalesTax.utils;
using System;
using System.Collections.Generic;

namespace SalesTax.Billing
{
    /// <summary>
    ///Class providing billing calculation and Invoice generation functionality .
    /// </summary>
    public class Biller
    {
        ITaxCalculator taxCalculator;

        public Biller(ITaxCalculator taxCalc)
        {
            taxCalculator = taxCalc;
        }

        public decimal CalculateTax(decimal price, decimal tax, bool imported)
        {

            decimal totalProductTax = taxCalculator.CalculateTax(price, tax, imported);
            return totalProductTax;
        }

        public decimal CalcTotalProductCost(decimal price, decimal tax)
        {
            return TaxUtil.Truncate(price + tax);
        }

        public decimal CalcTotalTax(List<Product> prodList)
        {
            decimal totalTax = 0.0M;

            foreach (Product p in prodList)
            {
                totalTax += (p.TaxedCost - p.Price);
            }

            return TaxUtil.Truncate(totalTax);
        }

        public decimal CalcTotalAmount(List<Product> prodList)
        {
            decimal totalAmount = 0.0M;

            foreach (Product p in prodList)
            {
                totalAmount += p.TaxedCost;
            }

            return TaxUtil.Truncate(totalAmount);
        }

        public Receipt CreateNewReceipt(List<Product> productList, decimal totalTax, decimal totalAmount)
        {
            return new Receipt(productList, totalTax, totalAmount);
        }

        public void GenerateReceipt(Receipt r)
        {
            string receipt = r.ToString();
            Console.WriteLine(receipt);
        }

    }
}
