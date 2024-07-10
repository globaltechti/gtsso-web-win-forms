using Newtonsoft.Json;

namespace GTSSO_WinFormsClient.Models
{
    public class Account
    {
        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
    }
}
