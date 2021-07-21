using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class PriceManager
    {
        private readonly List<ProductList> productlist = new List<ProductList>();

        public PriceManager AddProduct(string productCode, decimal singleUnitPrice)
        {
            DoAddProduct(productCode, new SiglePiecePrice(singleUnitPrice));
            return this;
        }

        public PriceManager AddProduct(string productCode, decimal singleUnitPrice, int volumeSize, decimal volumePrice)
        {
            DoAddProduct(productCode, new PriceCalculator(singleUnitPrice, volumeSize, volumePrice));
            return this;
        }

        private void DoAddProduct(string code, ITerminal price)
        {
            productlist.Add(new ProductList(code, price));
        }
    }
}
