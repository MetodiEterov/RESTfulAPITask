using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class BgBG
    {
        [JsonPropertyName("orders_products_id")]
        public string OrdersProductsId { get; set; }

        [JsonPropertyName("language_code")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("products_name")]
        public string ProductsName { get; set; }
    }
}
