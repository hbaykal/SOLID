﻿using SRP.Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ecommerce.After
{
    public class OnlineOrder : Order
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;
        private readonly IReservationService _reservationService;
        public OnlineOrder(ShoppingCart shoppingCart, PaymentDetails paymentDetails, IPaymentService paymentService,
            INotificationService notificationService, IReservationService reservationService) : base(shoppingCart)
        {
            _paymentDetails = paymentDetails;
            _paymentService = paymentService;
            _reservationService = reservationService;
            _notificationService = notificationService;
        }

        public override void Checkout()
        {
            _paymentService.ProcessCreditCard(_paymentDetails, ShoppingCart.TotalAmount);
            _reservationService.ReserveInventory(ShoppingCart.Items);
            _notificationService.NotifyCustomerOrderCreated(ShoppingCart);
            base.Checkout();
        }
    }
}
