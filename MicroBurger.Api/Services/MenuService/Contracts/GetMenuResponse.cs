using Order.Api.Services.MenuService.Models;
using System.Collections.Generic;

namespace Order.Api.Services.MenuService.Contracts
{
    public class GetMenuResponse
    {
        IReadOnlyCollection<MenuItem> Items { get; set; }
    }
}
