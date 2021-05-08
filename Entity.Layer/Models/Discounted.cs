using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Discounted
    {
        [JsonPropertyName("plain")]
        public Plain Plain { get; set; }

        [JsonPropertyName("formatted")]
        public Formatted Formatted { get; set; }
    }
}
