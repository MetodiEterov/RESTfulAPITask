using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Slot
    {
        [JsonPropertyName("data")]
        public Data3 Data { get; set; }
    }
}
