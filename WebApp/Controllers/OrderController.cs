using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Service;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpPost]
        [Route("{createBy}")]
        public async Task Post(string createBy, [FromBody] IDictionary<string, IEnumerable<OrderDetailDto>> dic)
        {
            var orderDetailsList = dic["orderDetails"];
            await _orderDetailService.SubmitAsync(createBy, orderDetailsList);
        }
        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            return Ok("success!!!");
        }
    }
}
