using System;

namespace Order.Api.Services.OrderService.Models
{
    public class Order
    {
        public Guid Id { get; private set; }
        public PaymentMethod PaymentMethod {get ;set;}
        public bool Payed { get; set; }
        public int BurgerType { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public string CommentsForDeliverer { get; set; }
    }

    public enum PaymentMethod
    {
        Online,
        AfterDelivey
    }

    public enum OrderStatus
    {
        WaitingForPayment,
        WaitingForPaymentConfirmation,
        WaitingForKitchen,
        Preparing,
        ReadyForDelivery,
        InDelivery,
        Delivered
    }
}
