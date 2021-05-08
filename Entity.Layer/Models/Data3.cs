using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Data3
    {
        [JsonPropertyName("marketplaces_regions_id")]
        public string MarketplacesRegionsId { get; set; }

        [JsonPropertyName("marketplaces_websites_id")]
        public string MarketplacesWebsitesId { get; set; }

        [JsonPropertyName("marketplaces_websites_name")]
        public string MarketplacesWebsitesName { get; set; }

        [JsonPropertyName("marketplaces_websites_website")]
        public string MarketplacesWebsitesWebsite { get; set; }

        [JsonPropertyName("marketplaces_websites_group")]
        public string MarketplacesWebsitesGroup { get; set; }

        [JsonPropertyName("marketplaces_tag")]
        public string MarketplacesTag { get; set; }

        [JsonPropertyName("marketplaces_websites_logo")]
        public string MarketplacesWebsitesLogo { get; set; }

        [JsonPropertyName("marketplaces_websites_active")]
        public string MarketplacesWebsitesActive { get; set; }

        [JsonPropertyName("marketplaces_websites_group_order")]
        public string MarketplacesWebsitesGroupOrder { get; set; }

        [JsonPropertyName("marketplaces_websites_subgroup_order")]
        public string MarketplacesWebsitesSubgroupOrder { get; set; }

        [JsonPropertyName("marketplaces_countries_iso_code_2")]
        public string MarketplacesCountriesIsoCode2 { get; set; }

        [JsonPropertyName("marketplaces_regions_name")]
        public string MarketplacesRegionsName { get; set; }

        [JsonPropertyName("marketplaces_regions_order")]
        public string MarketplacesRegionsOrder { get; set; }

        [JsonPropertyName("marketplaces_regions_active")]
        public string MarketplacesRegionsActive { get; set; }

        [JsonPropertyName("additionalData")]
        public AdditionalData AdditionalData { get; set; }

        [JsonPropertyName("slots_id")]
        public string SlotsId { get; set; }

        [JsonPropertyName("deployments_id")]
        public string DeploymentsId { get; set; }

        [JsonPropertyName("included_in_plan")]
        public string IncludedInPlan { get; set; }

        [JsonPropertyName("erased")]
        public string Erased { get; set; }

        [JsonPropertyName("slots_note")]
        public string SlotsNote { get; set; }

        [JsonPropertyName("replica_of")]
        public object ReplicaOf { get; set; }

        [JsonPropertyName("do_invoice")]
        public string DoInvoice { get; set; }

        [JsonPropertyName("batches_id")]
        public object BatchesId { get; set; }

        [JsonPropertyName("allow_pos_precedence")]
        public string AllowPosPrecedence { get; set; }

        [JsonPropertyName("invoice_number_start")]
        public object InvoiceNumberStart { get; set; }

        [JsonPropertyName("ship_from_countries_iso_code_2")]
        public object ShipFromCountriesIsoCode2 { get; set; }

        [JsonPropertyName("isConfigured")]
        public bool IsConfigured { get; set; }

        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("marketplace")]
        public Marketplace Marketplace { get; set; }

        [JsonPropertyName("createdDate")]
        public string CreatedDate { get; set; }

        [JsonPropertyName("isWipeable")]
        public bool IsWipeable { get; set; }

        [JsonPropertyName("isEraseable")]
        public bool IsEraseable { get; set; }

        [JsonPropertyName("isDeactivateable")]
        public bool IsDeactivateable { get; set; }

        [JsonPropertyName("isIncludedInPlan")]
        public bool IsIncludedInPlan { get; set; }

        [JsonPropertyName("placementScheme")]
        public string PlacementScheme { get; set; }

        [JsonPropertyName("cancellableTimestamp")]
        public string CancellableTimestamp { get; set; }

        [JsonPropertyName("isReplica")]
        public bool IsReplica { get; set; }

        [JsonPropertyName("slot")]
        public Slot Slot { get; set; }

        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("orders_id2")]
        public string OrdersId2 { get; set; }

        [JsonPropertyName("users_id")]
        public string UsersId { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("restaurant_users_id")]
        public string RestaurantUsersId { get; set; }

        [JsonPropertyName("slave_restaurant_users_id")]
        public object SlaveRestaurantUsersId { get; set; }

        [JsonPropertyName("created_ts")]
        public string CreatedTs { get; set; }

        [JsonPropertyName("last_update")]
        public string LastUpdate { get; set; }

        [JsonPropertyName("purchased_ts")]
        public string PurchasedTs { get; set; }

        [JsonPropertyName("payment_code")]
        public string PaymentCode { get; set; }

        [JsonPropertyName("subpayment_code")]
        public object SubpaymentCode { get; set; }

        [JsonPropertyName("currencies_iso_code")]
        public string CurrenciesIsoCode { get; set; }

        [JsonPropertyName("statuses_id")]
        public string StatusesId { get; set; }

        [JsonPropertyName("language_code")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("domains_id")]
        public string DomainsId { get; set; }

        [JsonPropertyName("remote_addr")]
        public object RemoteAddr { get; set; }

        [JsonPropertyName("comments")]
        public object Comments { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("delivery_takeout")]
        public string DeliveryTakeout { get; set; }

        [JsonPropertyName("hidden")]
        public string Hidden { get; set; }

        [JsonPropertyName("version")]
        public object Version { get; set; }

        [JsonPropertyName("user_agent")]
        public object UserAgent { get; set; }

        [JsonPropertyName("backend")]
        public object Backend { get; set; }

        [JsonPropertyName("referral_code")]
        public object ReferralCode { get; set; }

        [JsonPropertyName("processed_invoice")]
        public string ProcessedInvoice { get; set; }

        [JsonPropertyName("has_settlements_attributed")]
        public string HasSettlementsAttributed { get; set; }

        [JsonPropertyName("total_verified")]
        public string TotalVerified { get; set; }

        [JsonPropertyName("total_verification_ts")]
        public string TotalVerificationTs { get; set; }

        [JsonPropertyName("vat_number")]
        public string VatNumber { get; set; }

        [JsonPropertyName("exposed_via_api")]
        public string ExposedViaApi { get; set; }

        [JsonPropertyName("acknowledged")]
        public string Acknowledged { get; set; }

        [JsonPropertyName("origins_id")]
        public string OriginsId { get; set; }

        [JsonPropertyName("notify_failed_amazon_invoice_uploads")]
        public string NotifyFailedAmazonInvoiceUploads { get; set; }

        [JsonPropertyName("order_mfn_data")]
        public OrderMfnData OrderMfnData { get; set; }

        [JsonPropertyName("last_order_status")]
        public LastOrderStatus LastOrderStatus { get; set; }

        [JsonPropertyName("order_products")]
        public List<OrderProduct> OrderProducts { get; set; }

        [JsonPropertyName("order_address_details")]
        public OrderAddressDetails OrderAddressDetails { get; set; }

        [JsonPropertyName("order_non_tangibles")]
        public List<OrderNonTangible> OrderNonTangibles { get; set; }

        [JsonPropertyName("order_subtotal_w_addons")]
        public OrderSubtotalWAddons OrderSubtotalWAddons { get; set; }

        [JsonPropertyName("order_subtotal")]
        public OrderSubtotal OrderSubtotal { get; set; }

        [JsonPropertyName("order_subtotal_w_nontangibles")]
        public OrderSubtotalWNontangibles OrderSubtotalWNontangibles { get; set; }

        [JsonPropertyName("order_tax")]
        public OrderTax OrderTax { get; set; }

        [JsonPropertyName("order_tax_wo_handling_wo_invoice")]
        public OrderTaxWoHandlingWoInvoice OrderTaxWoHandlingWoInvoice { get; set; }

        [JsonPropertyName("order_total")]
        public OrderTotal OrderTotal { get; set; }

        [JsonPropertyName("order_total_wo_handling_wo_invoice")]
        public OrderTotalWoHandlingWoInvoice OrderTotalWoHandlingWoInvoice { get; set; }

        [JsonPropertyName("order_total_wo_invoice")]
        public OrderTotalWoInvoice OrderTotalWoInvoice { get; set; }

        [JsonPropertyName("order_restaurant")]
        public OrderRestaurant OrderRestaurant { get; set; }

        [JsonPropertyName("order_invoice")]
        public OrderInvoice OrderInvoice { get; set; }

        [JsonPropertyName("payment_name")]
        public string PaymentName { get; set; }

        [JsonPropertyName("isCustomerCancelled")]
        public bool IsCustomerCancelled { get; set; }

        [JsonPropertyName("utm")]
        public object Utm { get; set; }

        [JsonPropertyName("marketplace_link")]
        public string MarketplaceLink { get; set; }

        [JsonPropertyName("order_afn_data")]
        public OrderAfnData OrderAfnData { get; set; }
    }
}
