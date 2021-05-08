using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Marketplace
    {
        [JsonPropertyName("data")]
        public Data3 Data { get; set; }

    }
}
