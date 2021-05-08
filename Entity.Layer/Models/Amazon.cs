using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Amazon
    {
        [JsonPropertyName("marketplaces_websites_id")]
        public string MarketplacesWebsitesId { get; set; }

        [JsonPropertyName("marketplace_name")]
        public string MarketplaceName { get; set; }

        [JsonPropertyName("countries_iso_code_2")]
        public string CountriesIsoCode2 { get; set; }

        [JsonPropertyName("mws_endpoint")]
        public string MwsEndpoint { get; set; }

        [JsonPropertyName("MarketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonPropertyName("marketplace_website")]
        public string MarketplaceWebsite { get; set; }

        [JsonPropertyName("sp_api_endpoint")]
        public string SpApiEndpoint { get; set; }
    }
}
