using Newtonsoft.Json;

namespace GTSSO_WinFormsClient.Models
{
    public class ResourceAccess
    {
        [JsonProperty("account")]
        public Account Account { get; set; }
    }
}
