using Newtonsoft.Json;

namespace GTSSO_WinFormsClient.Models
{
    public class RealmAccess
    {
        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
    }
}
