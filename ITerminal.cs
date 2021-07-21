using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public interface ITerminal
    {
        decimal Price(int Item, decimal Price);
    }
}
