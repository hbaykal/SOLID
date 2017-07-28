using SRP.Ecommerce.Before;
using SRP.Ecommerce.Model;
using System;
using System.Collections.Generic;
using After = SRP.Ecommerce.After;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Program
    {
        
        static void Main()
        {
            //EcommerceBefore();
            EcommerceAfter();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void EcommerceBefore()
        {
            List<OrderItem> items = new List<OrderItem>();
            items.Add(new OrderItem() { Identifier = "Ekmek", Quantity = 5 });
            items.Add(new OrderItem() { Identifier = "Peynir", Quantity = 2 });
            ShoppingCart shoppingCart = new ShoppingCart() { CustomerEmail = "test@asd.com", Items = items, TotalAmount = 25 };
            PaymentDetails paymentDetails = new PaymentDetails() { CardholderName = "Hakkı Baykal", CreditCardNumber = "12345679932140", ExpiryDate = DateTime.Now.AddYears(2), PaymentMethod = PaymentMethod.CreditCard };

            Order order = new Order();
            order.Checkout(shoppingCart, paymentDetails, true);
        }

        private static void EcommerceAfter()
        {
            List<OrderItem> items = new List<OrderItem>();
            items.Add(new OrderItem() { Identifier = "Yumurta", Quantity = 7 });
            items.Add(new OrderItem() { Identifier = "Süt", Quantity = 3 });
            ShoppingCart shoppingCart = new ShoppingCart() { CustomerEmail = "test@asd.com", Items = items, TotalAmount = 25 };
            PaymentDetails paymentDetails = new PaymentDetails() { CardholderName = "Hakkı Baykal", CreditCardNumber = "12345679932140", ExpiryDate = DateTime.Now.AddYears(2), PaymentMethod = PaymentMethod.CreditCard };

            After.OnlineOrder order = new After.OnlineOrder(shoppingCart,paymentDetails,
                new Ecommerce.After.PaymentService(), new Ecommerce.After.NotificationService(), new Ecommerce.After.ReservationService());
            order.Checkout();
        }
    }
}
