﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ecommerce.Before
{
    public class Order
    {
        public void Checkout(ShoppingCart shoppingCart, PaymentDetails paymentDetails, bool notifyCustomer)
        {
            if (paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                ChargeCard(paymentDetails, shoppingCart);
            }

            ReserveInventory(shoppingCart);

            if (notifyCustomer)
            {
                NotifyCustomer(shoppingCart);
            }
        }

        public void NotifyCustomer(ShoppingCart cart)
        {
            string customerEmail = cart.CustomerEmail;
            if (!String.IsNullOrEmpty(customerEmail))
            {
                try
                {
                    //construct the email message and send it, implementation ignored
                }
                catch (Exception ex)
                {
                    //log the emailing error, implementation ignored
                }
            }
        }

        public void ReserveInventory(ShoppingCart cart)
        {
            foreach (OrderItem item in cart.Items)
            {
                try
                {
                    InventoryService inventoryService = new InventoryService();
                    inventoryService.Reserve(item.Identifier, item.Quantity);

                }
                catch (InsufficientInventoryException ex)
                {
                    throw new OrderException("Insufficient inventory for item " + item.Identifier, ex);
                }
                catch (Exception ex)
                {
                    throw new OrderException("Problem reserving inventory", ex);
                }
            }
        }

        public void ChargeCard(PaymentDetails paymentDetails, ShoppingCart cart)
        {
            PaymentService paymentService = new PaymentService();

            try
            {
                paymentService.Credentials = "Credentials";
                paymentService.CardNumber = paymentDetails.CreditCardNumber;
                paymentService.ExpiryDate = paymentDetails.ExpiryDate;
                paymentService.NameOnCard = paymentDetails.CardholderName;
                paymentService.AmountToCharge = cart.TotalAmount;

                paymentService.Charge();
            }
            catch (AccountBalanceMismatchException ex)
            {
                throw new OrderException("The card gateway rejected the card based on the address provided.", ex);
            }
            catch (Exception ex)
            {
                throw new OrderException("There was a problem with your card.", ex);
            }
        }
    }
    public class OrderException : Exception
    {
        public OrderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
