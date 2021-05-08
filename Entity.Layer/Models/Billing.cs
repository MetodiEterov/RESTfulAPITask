using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class Billing
    {
        [JsonPropertyName("orders_id")]
        public string OrdersId { get; set; }

        [JsonPropertyName("users_id")]
        public object UsersId { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("addressbook_id")]
        public object AddressbookId { get; set; }

        [JsonPropertyName("company_name")]
        public object CompanyName { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("address2")]
        public object Address2 { get; set; }

        [JsonPropertyName("cities_name")]
        public string CitiesName { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("countries_iso_code_2")]
        public string CountriesIsoCode2 { get; set; }

        [JsonPropertyName("countries_name")]
        public string CountriesName { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("flights_of_stairs")]
        public object FlightsOfStairs { get; set; }

        [JsonPropertyName("entry_code")]
        public object EntryCode { get; set; }

        [JsonPropertyName("mecenatkort")]
        public object Mecenatkort { get; set; }

        [JsonPropertyName("national_ID_number")]
        public object NationalIDNumber { get; set; }
    }
}
