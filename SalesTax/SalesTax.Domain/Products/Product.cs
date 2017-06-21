using SalesTax.ProductFactories;
using System;

namespace SalesTax.Products
{
    /// <summary>
    ///  Product is an Abstract Super Class 
    /// </summary>
    public abstract class Product
    {
        protected string Name { get; set; }

        private decimal _price;
        public decimal Price
        {
            set { _price = value; }
            get { return _price * Quantity; }
        }

        public bool Imported { get; set; }

        public int Quantity { get; set; }

        public decimal TaxedCost { get; set; }

        public Product()
        {
            this.Name = string.Empty;
            this.Price = 0.0M;
            this.Imported = false;
            this.Quantity = 0;
            this.TaxedCost = 0.0M;
        }

        public Product(string name, decimal price, bool imported, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Imported = imported;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return (Quantity + " " + ImportedToString(Imported) + " " + Name + " : " + TaxedCost.ToString("F"));
        }

        public string ImportedToString(bool imported)
        {
            if (!imported)
                return string.Empty;
            else
                return "imported";
        }

        public abstract ProductFactory GetFactory();

        public abstract decimal GetTaxValue(string country);
    }
}
