﻿using SalesTax.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingStore store = new ShoppingStore();
            store.GetSalesOrder();
            Console.ReadKey();
        }
    }
}
