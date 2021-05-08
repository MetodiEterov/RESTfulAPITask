using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderTaxWoHandlingWoInvoice
    {
        [JsonPropertyName("html_excl_VAT")]
        public string HtmlExclVAT { get; set; }

        [JsonPropertyName("plain_excl_VAT")]
        public double PlainExclVAT { get; set; }

        [JsonPropertyName("plain_incl_VAT")]
        public double PlainInclVAT { get; set; }

        [JsonPropertyName("html_incl_VAT")]
        public string HtmlInclVAT { get; set; }

        [JsonPropertyName("incl_tax")]
        public InclTax InclTax { get; set; }

        [JsonPropertyName("discounted")]
        public Discounted Discounted { get; set; }

        [JsonPropertyName("excl_tax")]
        public ExclTax ExclTax { get; set; }

        [JsonPropertyName("tax_class_id")]
        public object TaxClassId { get; set; }

        [JsonPropertyName("tax_rate")]
        public object TaxRate { get; set; }

        [JsonPropertyName("discount_percentage")]
        public int DiscountPercentage { get; set; }
    }
}
