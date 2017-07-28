using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Customer.After
{
    public interface IOrderService
    {
        void CreateOrder();
    }
    public class OrderService : IOrderService
    {
        public void CreateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
