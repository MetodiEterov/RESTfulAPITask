using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class MultilangData
    {
        [JsonPropertyName("bg_BG")]
        public BgBG BgBG { get; set; }

        [JsonPropertyName("de_DE")]
        public DeDE DeDE { get; set; }

        [JsonPropertyName("es_ES")]
        public EsES EsES { get; set; }

        [JsonPropertyName("cs_CZ")]
        public CsCZ CsCZ { get; set; }

        [JsonPropertyName("it_IT")]
        public ItIT ItIT { get; set; }

        [JsonPropertyName("fr_FR")]
        public FrFR FrFR { get; set; }
    }
}
