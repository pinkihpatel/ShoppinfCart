using System;
using System.Diagnostics.Contracts;

namespace ShoppingCart
{
    public class PriceCalculator : ITerminal
    {
        private readonly SiglePiecePrice singlepieceprice;
        private readonly decimal productprize;
        private readonly int productsize;
       
        public PriceCalculator(decimal singleUnitPrice, int size, decimal prize)
        {
            Contract.Requires(size > 0);
            Contract.Requires(prize > 0.0M);

            singlepieceprice = new SiglePiecePrice(singleUnitPrice);
            this.productsize = size;
            this.productprize = prize;
        }

        decimal ITerminal.Price(int item, decimal price)
        {
            return (item / productsize) * productprize + singlepieceprice.Price(item % productsize, price);
        }
    }
}
