using Order.Api.Models;
using System.Collections.Generic;

namespace Order.Api.Contracts
{
    public class GetMenuResponse
    {
        public IReadOnlyCollection<MenuItem> Items;
    }
}
