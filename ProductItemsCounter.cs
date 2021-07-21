using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class ProductItemsCounter
    {
        private readonly ITerminal priceCounter;
        private int itemsCount = 0;

        public ProductItemsCounter(ITerminal price)
        {
            this.priceCounter = price;
        }

        public void AddItem()
        {
            itemsCount++;
        }

        public decimal GetTotalPrice(decimal discountRate)
        {
            return priceCounter.Price(itemsCount, discountRate);
        }
    }
}
