using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Entity.Layer.Common;
using Entity.Layer.Contracts;

using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Layer.Controllers
{
    /// <summary>
    /// WebAPIController class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WebAPIController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public WebAPIController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        // GET: api/<WebAPIController>
        /// <summary>
        /// Get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<object>> Get()
        {
            var orders = await _orderRepository.GetAllOrders();

            // Return mock data if hasn't real data
            if (orders == null) return Constants.mockOrders;

            return orders;
        }
    }
}
