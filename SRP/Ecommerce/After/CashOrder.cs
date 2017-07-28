using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ecommerce.After
{
    public class CashOrder : Order
    {
        public CashOrder(ShoppingCart shoppingCart) : base(shoppingCart)
        {
        }
    }
}
