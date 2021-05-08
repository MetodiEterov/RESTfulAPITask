using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderInvoice
    {
        [JsonPropertyName("invoices_id")]
        public string InvoicesId { get; set; }

        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("users_id")]
        public string UsersId { get; set; }

        [JsonPropertyName("batches_id")]
        public string BatchesId { get; set; }

        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("issuance_date")]
        public string IssuanceDate { get; set; }

        [JsonPropertyName("tax_point")]
        public string TaxPoint { get; set; }

        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }

        [JsonPropertyName("created_ts")]
        public string CreatedTs { get; set; }

        [JsonPropertyName("place_of_supply")]
        public string PlaceOfSupply { get; set; }

        [JsonPropertyName("fx_date")]
        public string FxDate { get; set; }

        [JsonPropertyName("fx_rate")]
        public string FxRate { get; set; }

        [JsonPropertyName("fx_institution")]
        public string FxInstitution { get; set; }

        [JsonPropertyName("fx_rate_home_jurisdiction")]
        public string FxRateHomeJurisdiction { get; set; }

        [JsonPropertyName("fx_institution_home_jurisdiction")]
        public string FxInstitutionHomeJurisdiction { get; set; }

        [JsonPropertyName("fx_rate_home_jurisdiction2")]
        public string FxRateHomeJurisdiction2 { get; set; }

        [JsonPropertyName("buyer_company_id")]
        public object BuyerCompanyId { get; set; }

        [JsonPropertyName("buyer_vat_id")]
        public string BuyerVatId { get; set; }

        [JsonPropertyName("supplier_company_id")]
        public string SupplierCompanyId { get; set; }

        [JsonPropertyName("supplier_vat_id")]
        public string SupplierVatId { get; set; }

        [JsonPropertyName("supplier_bic")]
        public string SupplierBic { get; set; }

        [JsonPropertyName("supplier_iban")]
        public string SupplierIban { get; set; }

        [JsonPropertyName("supplier_paypal_account")]
        public object SupplierPaypalAccount { get; set; }

        [JsonPropertyName("note_type")]
        public object NoteType { get; set; }

        [JsonPropertyName("note_ref_invoices_id")]
        public object NoteRefInvoicesId { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("show_discounts")]
        public string ShowDiscounts { get; set; }

        [JsonPropertyName("on_id")]
        public object OnId { get; set; }

        [JsonPropertyName("amazon_last_upload")]
        public object AmazonLastUpload { get; set; }

        [JsonPropertyName("invoice_number_formatted")]
        public string InvoiceNumberFormatted { get; set; }
    }
}
