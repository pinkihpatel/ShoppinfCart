using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    
    public class ProductList
    {
        public ProductList(string productCode, ITerminal priceCalculator)
        {
            ProductCode = productCode;
            Price = priceCalculator;
        }

        public string ProductCode { get; private set; }

        public ITerminal Price { get; private set; }
    }
}
