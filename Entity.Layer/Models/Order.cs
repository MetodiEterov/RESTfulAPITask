using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Order
    {
        [JsonPropertyName("orders_id")]
        public int OrdersId { get; set; }

        [JsonPropertyName("cacheTTL")]
        public int CacheTTL { get; set; }

        [JsonPropertyName("isCachedInstance")]
        public bool IsCachedInstance { get; set; }

        [JsonPropertyName("skip_nontangibles_keys")]
        public object SkipNontangiblesKeys { get; set; }

        [JsonPropertyName("jurisdiction")]
        public object Jurisdiction { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("fx_rate")]
        public int FxRate { get; set; }

        [JsonPropertyName("isInvoiced")]
        public bool IsInvoiced { get; set; }

        [JsonPropertyName("data")]
        public Data3 Data { get; set; }

        [JsonPropertyName("status_history")]
        public List<StatusHistory> StatusHistory { get; set; }

        [JsonPropertyName("is_paid")]
        public bool IsPaid { get; set; }

        [JsonPropertyName("is_acquired")]
        public bool IsAcquired { get; set; }

        [JsonPropertyName("is_declined")]
        public bool IsDeclined { get; set; }

        [JsonPropertyName("isPlacedByRegisteredCustomer")]
        public bool IsPlacedByRegisteredCustomer { get; set; }
    }
}
