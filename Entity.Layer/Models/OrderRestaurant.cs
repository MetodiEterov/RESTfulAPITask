using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class OrderRestaurant
    {
        [JsonPropertyName("users_types_id")]
        public string UsersTypesId { get; set; }

        [JsonPropertyName("users_id")]
        public string UsersId { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("active")]
        public string Active { get; set; }

        [JsonPropertyName("registered_timestamp")]
        public string RegisteredTimestamp { get; set; }

        [JsonPropertyName("last_login")]
        public string LastLogin { get; set; }

        [JsonPropertyName("email_optin")]
        public string EmailOptin { get; set; }

        [JsonPropertyName("domains_id")]
        public string DomainsId { get; set; }

        [JsonPropertyName("2fa_required")]
        public string _2faRequired { get; set; }

        [JsonPropertyName("is_enrolment_required")]
        public string IsEnrolmentRequired { get; set; }

        [JsonPropertyName("token")]
        public object Token { get; set; }

        [JsonPropertyName("token_created")]
        public object TokenCreated { get; set; }

        [JsonPropertyName("users_types_type")]
        public string UsersTypesType { get; set; }

        [JsonPropertyName("users_types_label")]
        public string UsersTypesLabel { get; set; }

        [JsonPropertyName("ud_id")]
        public string UdId { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("phone_countries_iso_code_2")]
        public object PhoneCountriesIsoCode2 { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("mobile_countries_iso_code_2")]
        public object MobileCountriesIsoCode2 { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("last_delegator")]
        public string LastDelegator { get; set; }

        [JsonPropertyName("language_code")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("countries_iso_code_2")]
        public string CountriesIsoCode2 { get; set; }

        [JsonPropertyName("cities_id")]
        public string CitiesId { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        [JsonPropertyName("company_registration_number")]
        public string CompanyRegistrationNumber { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("delivery_fee")]
        public string DeliveryFee { get; set; }

        [JsonPropertyName("free_delivery_over")]
        public string FreeDeliveryOver { get; set; }

        [JsonPropertyName("restaurant_name")]
        public string RestaurantName { get; set; }

        [JsonPropertyName("global_discount")]
        public string GlobalDiscount { get; set; }

        [JsonPropertyName("minimum_order_value")]
        public string MinimumOrderValue { get; set; }

        [JsonPropertyName("enforce_minimum_order_value")]
        public string EnforceMinimumOrderValue { get; set; }

        [JsonPropertyName("allow_order_decline")]
        public string AllowOrderDecline { get; set; }

        [JsonPropertyName("parent_users_id")]
        public object ParentUsersId { get; set; }

        [JsonPropertyName("menus_id")]
        public object MenusId { get; set; }

        [JsonPropertyName("home_jurisdiction")]
        public string HomeJurisdiction { get; set; }
    }
}
