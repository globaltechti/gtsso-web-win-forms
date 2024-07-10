using Newtonsoft.Json;

namespace GTSSO_WinFormsClient.Models.Responses
{
    public class UserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("createdTimestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("totp")]
        public bool Totp { get; set; }

        [JsonProperty("disableableCredentialTypes")]
        public List<object> DisableableCredentialTypes { get; set; }

        [JsonProperty("requiredActions")]
        public List<object> RequiredActions { get; set; }

        [JsonProperty("notBefore")]
        public int NotBefore { get; set; }

        [JsonProperty("access")]
        public AccessResponse Access { get; set; } = new AccessResponse();
    }
}
