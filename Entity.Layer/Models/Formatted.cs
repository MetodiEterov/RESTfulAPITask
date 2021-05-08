using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Formatted
    {
        [JsonPropertyName("excl_tax")]
        public string ExclTax { get; set; }

        [JsonPropertyName("incl_tax")]
        public string InclTax { get; set; }
    }
}
