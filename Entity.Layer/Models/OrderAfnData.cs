using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderAfnData
    {
        [JsonPropertyName("fulfillment_center_id")]
        public string FulfillmentCenterId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("reportId")]
        public string ReportId { get; set; }

        [JsonPropertyName("amazon_order_id")]
        public string AmazonOrderId { get; set; }

        [JsonPropertyName("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("shipment_id")]
        public string ShipmentId { get; set; }

        [JsonPropertyName("shipment_item_id")]
        public string ShipmentItemId { get; set; }

        [JsonPropertyName("amazon_order_item_id")]
        public string AmazonOrderItemId { get; set; }

        [JsonPropertyName("merchant_order_item_id")]
        public string MerchantOrderItemId { get; set; }

        [JsonPropertyName("purchase_date")]
        public string PurchaseDate { get; set; }

        [JsonPropertyName("payments_date")]
        public string PaymentsDate { get; set; }

        [JsonPropertyName("shipment_date")]
        public string ShipmentDate { get; set; }

        [JsonPropertyName("reporting_date")]
        public string ReportingDate { get; set; }

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

        [JsonPropertyName("quantity_shipped")]
        public string QuantityShipped { get; set; }

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

        [JsonPropertyName("gift_wrap_price")]
        public string GiftWrapPrice { get; set; }

        [JsonPropertyName("gift_wrap_tax")]
        public string GiftWrapTax { get; set; }

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

        [JsonPropertyName("bill_address_1")]
        public string BillAddress1 { get; set; }

        [JsonPropertyName("bill_address_2")]
        public string BillAddress2 { get; set; }

        [JsonPropertyName("bill_address_3")]
        public string BillAddress3 { get; set; }

        [JsonPropertyName("bill_city")]
        public string BillCity { get; set; }

        [JsonPropertyName("bill_state")]
        public string BillState { get; set; }

        [JsonPropertyName("bill_postal_code")]
        public string BillPostalCode { get; set; }

        [JsonPropertyName("bill_country")]
        public string BillCountry { get; set; }

        [JsonPropertyName("item_promotion_discount")]
        public string ItemPromotionDiscount { get; set; }

        [JsonPropertyName("ship_promotion_discount")]
        public string ShipPromotionDiscount { get; set; }

        [JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonPropertyName("estimated_arrival_date")]
        public string EstimatedArrivalDate { get; set; }

        [JsonPropertyName("fulfillment_channel")]
        public string FulfillmentChannel { get; set; }

        [JsonPropertyName("sales_channel")]
        public string SalesChannel { get; set; }

        [JsonPropertyName("invoice_uploaded")]
        public string InvoiceUploaded { get; set; }

        [JsonPropertyName("TaxCollectionModel")]
        public string TaxCollectionModel { get; set; }

        [JsonPropertyName("ShippedByAmazonTFM")]
        public string ShippedByAmazonTFM { get; set; }

        [JsonPropertyName("IsBusinessOrder")]
        public string IsBusinessOrder { get; set; }

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

        [JsonPropertyName("afc_id")]
        public string AfcId { get; set; }

        [JsonPropertyName("countries_iso_code_2")]
        public string CountriesIsoCode2 { get; set; }

        [JsonPropertyName("states_code")]
        public object StatesCode { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("source_shipping_country")]
        public string SourceShippingCountry { get; set; }
    }
}