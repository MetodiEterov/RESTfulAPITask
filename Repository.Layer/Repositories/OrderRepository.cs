using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Entity.Layer.Contracts;
using Entity.Layer.Models;

using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

namespace Repository.Layer
{
    /// <summary>
    /// OrderRepository class
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<Root> _logger;

        private readonly string testAPI = "https://api.xxxxxxx.xx/api/v1/orders";

        /// <summary>
        /// OrderRepository constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="clientFactory"></param>
        public OrderRepository(ILogger<Root> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        /// <summary>
        /// GetAllOrders method
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Root>> GetAllOrders()
        {
            var client = _clientFactory.CreateClient("client");
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(testAPI),
                Method = HttpMethod.Get,
            };

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                if (responseContent != null) return JsonConvert.DeserializeObject<IEnumerable<Root>>(responseContent);
            }

            return null;
        }
    }
}
