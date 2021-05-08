using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Root
    {
        [JsonPropertyName("orders")]
        public List<Order> Orders { get; set; }

        [JsonPropertyName("hasNext")]
        public bool HasNext { get; set; }

        [JsonPropertyName("nextToken")]
        public string NextToken { get; set; }
    }
}
