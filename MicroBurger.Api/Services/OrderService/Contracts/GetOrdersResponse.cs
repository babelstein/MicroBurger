using System.Collections.Generic;

namespace Order.Api.Services.OrderService.Contracts
{
    using Models;

    public class GetOrdersResponse
    {
        IReadOnlyCollection<Order> Orders { get; set; }
    }
}
