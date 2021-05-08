using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderNonTangible
    {
        [JsonPropertyName("on_id")]
        public string OnId { get; set; }

        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("nontangibles_key")]
        public string NontangiblesKey { get; set; }

        [JsonPropertyName("nontangibles_subkey")]
        public object NontangiblesSubkey { get; set; }

        [JsonPropertyName("nontangibles_price")]
        public NontangiblesPrice NontangiblesPrice { get; set; }

        [JsonPropertyName("nontangibles_tax_rate")]
        public string NontangiblesTaxRate { get; set; }

        [JsonPropertyName("nontangibles_tax_class")]
        public object NontangiblesTaxClass { get; set; }

        [JsonPropertyName("nontangibles_quantity")]
        public string NontangiblesQuantity { get; set; }

        [JsonPropertyName("issuedCreditNote")]
        public string IssuedCreditNote { get; set; }

        [JsonPropertyName("isFromAmazonSettlement")]
        public string IsFromAmazonSettlement { get; set; }

        [JsonPropertyName("settlement_id")]
        public object SettlementId { get; set; }

        [JsonPropertyName("nontangibles_price_qty_adjusted")]
        public NontangiblesPriceQtyAdjusted NontangiblesPriceQtyAdjusted { get; set; }
    }
}
