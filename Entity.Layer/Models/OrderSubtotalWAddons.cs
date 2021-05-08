using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderSubtotalWAddons
    {
        [JsonPropertyName("incl_tax")]
        public InclTax InclTax { get; set; }

        [JsonPropertyName("excl_tax")]
        public ExclTax ExclTax { get; set; }
    }
}
