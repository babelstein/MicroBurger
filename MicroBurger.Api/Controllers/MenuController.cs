using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Order.Api.Contracts;
using Order.Api.Services.MenuService;
using System.Net;

namespace Order.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menu;
        private readonly IMapper _mapper;

        public MenuController(IMenuService menu, IMapper mapper)
        {
            _menu = menu;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GetMenuResponse), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var response = _menu.GetMenu();
            return Ok(_mapper.Map<GetMenuResponse>(response));
        }
    }
}
