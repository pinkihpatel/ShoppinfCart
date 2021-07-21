using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
  
    public class Product
    {
        private readonly Dictionary<string, ProductItemsCounter> data;

        public PriceManager PriceManager { get; }

        public Product(IEnumerable<ProductList> products)
        {
            Contract.Requires(products != null);
            Contract.Requires(products.Select(p => p.ProductCode).Distinct().Count() == products.Count(),
                              "Single product entry for each product code");

            data = products.ToDictionary(p => p.ProductCode, p => new ProductItemsCounter(p.Price));
        }

        public Product(PriceManager priceManager)
        {
            PriceManager = priceManager;
        }

        public decimal CalculateTotal()
        {
            return DoCalculateTotal();
        }
        private decimal DoCalculateTotal(decimal discountRate = 0.0M)
        {
            return data.Aggregate(0.0M, (a, pr) => a + pr.Value.GetTotalPrice(discountRate));
        }
    }
}
