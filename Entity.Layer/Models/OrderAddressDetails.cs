using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderAddressDetails
    {
        [JsonPropertyName("billing")]
        public Billing Billing { get; set; }

        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }
    }
}
