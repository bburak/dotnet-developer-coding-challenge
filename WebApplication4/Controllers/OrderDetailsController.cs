using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication4.Business;
using WebApplication4.DAL.Abstract;
using WebApplication4.Entities;
using WebApplication4.Entities.RequestModels;
using WebApplication4.Entities.ResponseModels;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderDetailsController(OrderService OrderService)
        {
            _orderService = OrderService;
        }

        [HttpPost]
        public async Task<TCreateOrder> CreateOrder([FromBody] RCreateOrder order)
        {
            try
            {
                var resp = await _orderService.CreateOrder(order);
                return resp;
            }
            catch (Exception ex)
            {
                return new TCreateOrder { Customer = ex.Message};
            }
        }
    }
}
