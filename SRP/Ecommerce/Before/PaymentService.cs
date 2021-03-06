﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ecommerce.Before
{
    public class PaymentService
    {
        public string CardNumber { get; set; }
        public string Credentials { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public decimal AmountToCharge { get; set; }
        public void Charge()
        {
            Console.WriteLine("PaymentService.Charge()");
        }
    }

    public class AccountBalanceMismatchException : Exception
    {
    }

    public class InventoryService
    {
        public void Reserve(string identifier, int quantity)
        {
            Console.WriteLine("InventoryService.Reserve()");
        }
    }

    public class InsufficientInventoryException : Exception
    {
    }
}
