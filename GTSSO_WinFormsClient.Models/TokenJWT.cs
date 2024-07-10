using Newtonsoft.Json;

namespace GTSSO_WinFormsClient.Models
{
    public class TokenJWT
    {
        [JsonProperty("exp")]
        public int Exp { get; set; }

        [JsonProperty("iat")]
        public int Iat { get; set; }

        [JsonProperty("jti")]
        public string Jti { get; set; }

        [JsonProperty("iss")]
        public string Iss { get; set; }

        [JsonProperty("aud")]
        public string Aud { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("typ")]
        public string Typ { get; set; }

        [JsonProperty("azp")]
        public string Azp { get; set; }

        [JsonProperty("session_state")]
        public string SessionState { get; set; }

        [JsonProperty("acr")]
        public string Acr { get; set; }

        [JsonProperty("allowed-origins")]
        public List<string> AllowedOrigins { get; set; }

        [JsonProperty("realm_access")]
        public RealmAccess RealmAccess { get; set; }

        [JsonProperty("resource_access")]
        public ResourceAccess ResourceAccess { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_username")]
        public string PreferredUsername { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
