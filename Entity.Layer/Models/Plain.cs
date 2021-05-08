using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Plain
    {
        [JsonPropertyName("excl_tax")]
        public double ExclTax { get; set; }

        [JsonPropertyName("incl_tax")]
        public double InclTax { get; set; }
    }
}
