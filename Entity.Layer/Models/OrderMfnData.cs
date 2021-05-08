using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderMfnData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("reportId")]
        public string ReportId { get; set; }

        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("order_item_id")]
        public string OrderItemId { get; set; }

        [JsonPropertyName("purchase_date")]
        public string PurchaseDate { get; set; }

        [JsonPropertyName("payments_date")]
        public string PaymentsDate { get; set; }

        [JsonPropertyName("buyer_email")]
        public string BuyerEmail { get; set; }

        [JsonPropertyName("buyer_name")]
        public string BuyerName { get; set; }

        [JsonPropertyName("buyer_phone_number")]
        public string BuyerPhoneNumber { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [JsonPropertyName("quantity_purchased")]
        public string QuantityPurchased { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("item_price")]
        public string ItemPrice { get; set; }

        [JsonPropertyName("item_tax")]
        public string ItemTax { get; set; }

        [JsonPropertyName("shipping_price")]
        public string ShippingPrice { get; set; }

        [JsonPropertyName("shipping_tax")]
        public string ShippingTax { get; set; }

        [JsonPropertyName("ship_service_level")]
        public string ShipServiceLevel { get; set; }

        [JsonPropertyName("recipient_name")]
        public string RecipientName { get; set; }

        [JsonPropertyName("ship_address_1")]
        public string ShipAddress1 { get; set; }

        [JsonPropertyName("ship_address_2")]
        public string ShipAddress2 { get; set; }

        [JsonPropertyName("ship_address_3")]
        public string ShipAddress3 { get; set; }

        [JsonPropertyName("ship_city")]
        public string ShipCity { get; set; }

        [JsonPropertyName("ship_state")]
        public string ShipState { get; set; }

        [JsonPropertyName("ship_postal_code")]
        public string ShipPostalCode { get; set; }

        [JsonPropertyName("ship_country")]
        public string ShipCountry { get; set; }

        [JsonPropertyName("ship_phone_number")]
        public string ShipPhoneNumber { get; set; }

        [JsonPropertyName("delivery_start_date")]
        public object DeliveryStartDate { get; set; }

        [JsonPropertyName("delivery_end_date")]
        public object DeliveryEndDate { get; set; }

        [JsonPropertyName("delivery_time_zone")]
        public string DeliveryTimeZone { get; set; }

        [JsonPropertyName("delivery_instructions")]
        public string DeliveryInstructions { get; set; }

        [JsonPropertyName("sales_channel")]
        public string SalesChannel { get; set; }

        [JsonPropertyName("is_business_order")]
        public string IsBusinessOrder { get; set; }

        [JsonPropertyName("purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        [JsonPropertyName("price_designation")]
        public string PriceDesignation { get; set; }

        [JsonPropertyName("invoice_uploaded")]
        public string InvoiceUploaded { get; set; }

        [JsonPropertyName("TaxCollectionModel")]
        public string TaxCollectionModel { get; set; }

        [JsonPropertyName("ShippedByAmazonTFM")]
        public string ShippedByAmazonTFM { get; set; }

        [JsonPropertyName("IsPrime")]
        public string IsPrime { get; set; }

        [JsonPropertyName("IsGlobalExpressEnabled")]
        public string IsGlobalExpressEnabled { get; set; }

        [JsonPropertyName("IsPremiumOrder")]
        public string IsPremiumOrder { get; set; }

        [JsonPropertyName("IsReplacementOrder")]
        public string IsReplacementOrder { get; set; }

        [JsonPropertyName("IsSoldByAB")]
        public string IsSoldByAB { get; set; }

        [JsonPropertyName("EarliestShipDate")]
        public string EarliestShipDate { get; set; }

        [JsonPropertyName("LatestShipDate")]
        public string LatestShipDate { get; set; }

        [JsonPropertyName("EarliestDeliveryDate")]
        public string EarliestDeliveryDate { get; set; }

        [JsonPropertyName("LatestDeliveryDate")]
        public string LatestDeliveryDate { get; set; }
    }
}
