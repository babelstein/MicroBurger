using System;
using Order.Api.Services.OrderService.Contracts;

namespace Order.Api.Services.OrderService
{
    public class OrderService : IOrderService
    {
        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public GetOrderResponse GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public GetOrdersResponse GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
