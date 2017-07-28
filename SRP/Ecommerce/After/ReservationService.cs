using SRP.Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ecommerce.After
{
    public class ReservationService : IReservationService
    {
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            Console.WriteLine("ReservationService.ReverseInventory()");
        }
    }

    public class PaymentService : IPaymentService
    {
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal moneyAmount)
        {
            Console.WriteLine("PaymentService.ProcessCreditCard()");
        }
    }

    public class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(ShoppingCart cart)
        {
            Console.WriteLine("NotificationService.NotifyCustomerOrderCreated()");
        }
    }
}
