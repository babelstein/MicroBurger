using Order.Api.Models;

namespace Order.Api.Contracts
{
    public class CreateOrderRequest
    {
        public PaymentMethod PaymentMethod { get; set; }
        public int BurgerType { get; set; }
    }
}
