using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderProduct
    {
        [JsonPropertyName("orders_products_id")]
        public string OrdersProductsId { get; set; }

        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("products_id")]
        public string ProductsId { get; set; }

        [JsonPropertyName("products_name")]
        public string ProductsName { get; set; }

        [JsonPropertyName("products_price")]
        public ProductsPrice ProductsPrice { get; set; }

        [JsonPropertyName("products_discount")]
        public string ProductsDiscount { get; set; }

        [JsonPropertyName("products_tax_rate")]
        public string ProductsTaxRate { get; set; }

        [JsonPropertyName("products_tax_class")]
        public string ProductsTaxClass { get; set; }

        [JsonPropertyName("products_quantity")]
        public string ProductsQuantity { get; set; }

        [JsonPropertyName("contents_default")]
        public string ContentsDefault { get; set; }

        [JsonPropertyName("contents_extras")]
        public object ContentsExtras { get; set; }

        [JsonPropertyName("isFromAmazonSettlement")]
        public string IsFromAmazonSettlement { get; set; }

        [JsonPropertyName("settlement_id")]
        public object SettlementId { get; set; }

        [JsonPropertyName("products_sku")]
        public string ProductsSku { get; set; }

        [JsonPropertyName("opc_id")]
        public object OpcId { get; set; }

        [JsonPropertyName("cpc_key")]
        public object CpcKey { get; set; }

        [JsonPropertyName("products_contents_id")]
        public object ProductsContentsId { get; set; }

        [JsonPropertyName("products_contents_name")]
        public object ProductsContentsName { get; set; }

        [JsonPropertyName("cpc_price")]
        public object CpcPrice { get; set; }

        [JsonPropertyName("quantity")]
        public object Quantity { get; set; }

        [JsonPropertyName("opv_id")]
        public object OpvId { get; set; }

        [JsonPropertyName("variants_id")]
        public object VariantsId { get; set; }

        [JsonPropertyName("variants_name")]
        public object VariantsName { get; set; }

        [JsonPropertyName("products_contents")]
        public List<object> ProductsContents { get; set; }

        [JsonPropertyName("contents_added")]
        public List<object> ContentsAdded { get; set; }

        [JsonPropertyName("contents_removed")]
        public List<bool> ContentsRemoved { get; set; }

        [JsonPropertyName("extras_added")]
        public List<object> ExtrasAdded { get; set; }

        [JsonPropertyName("products_full_name")]
        public string ProductsFullName { get; set; }

        [JsonPropertyName("products_price2")]
        public ProductsPrice2 ProductsPrice2 { get; set; }

        [JsonPropertyName("products_price3")]
        public ProductsPrice3 ProductsPrice3 { get; set; }

        [JsonPropertyName("multilang_data")]
        public MultilangData MultilangData { get; set; }
    }
}
