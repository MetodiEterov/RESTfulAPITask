using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class StatusHistory
    {
        [JsonPropertyName("orders_status_history_id")]
        public string OrdersStatusHistoryId { get; set; }

        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("statuses_id")]
        public string StatusesId { get; set; }

        [JsonPropertyName("created")]
        public string Created { get; set; }

        [JsonPropertyName("customer_notification")]
        public string CustomerNotification { get; set; }

        [JsonPropertyName("comments")]
        public object Comments { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("callbacks_id")]
        public object CallbacksId { get; set; }

        [JsonPropertyName("backend")]
        public string Backend { get; set; }
    }
}
