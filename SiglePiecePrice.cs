using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ShoppingCart
{
    internal class SiglePiecePrice :ITerminal
    {
        private readonly decimal perpieceprice;

        public SiglePiecePrice(decimal singleUnitPrice)
        {
            Contract.Requires(singleUnitPrice > 0.0M);

            this.perpieceprice = singleUnitPrice;
        }
        public decimal Price(int itemsCount, decimal discountRate)
        {
            return perpieceprice * itemsCount * (1.0M - discountRate);
        }
       
    }
}
