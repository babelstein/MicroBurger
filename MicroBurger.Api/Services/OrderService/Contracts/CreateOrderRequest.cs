using Order.Api.Services.OrderService.Models;

namespace Order.Api.Services.OrderService.Contracts
{
    public class CreateOrderRequest
    {
        public PaymentMethod PaymentMethod { get; set; }
        public int BurgerType { get; set; }
    }
}
