using Order.Api.Services.OrderService.Contracts;
using System;

namespace Order.Api.Services.OrderService
{
    public interface IOrderService
    {
        GetOrdersResponse GetOrders();
        GetOrderResponse GetOrder(Guid orderId);
        CreateOrderResponse CreateOrder(CreateOrderRequest request);
    }
}
