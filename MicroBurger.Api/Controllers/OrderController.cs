using System;
using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Order.Api.Contracts;
using Order.Api.Services.OrderService;

namespace Order.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(GetOrdersResponse), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var response = _orderService.GetOrders();
            return Ok(_mapper.Map<GetOrdersResponse>(response));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetOrderResponse), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            var response = _orderService.GetOrder(id);
            return Ok(_mapper.Map<GetOrderResponse>(response));
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(CreateOrderResponse), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] CreateOrderRequest request)
        {
            var response = _orderService.CreateOrder(_mapper.Map<Services.OrderService.Contracts.CreateOrderRequest>(request));
            return Ok(_mapper.Map<CreateOrderResponse>(response));
        }
    }
}
