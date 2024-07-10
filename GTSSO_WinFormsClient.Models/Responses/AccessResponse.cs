﻿using Newtonsoft.Json;


namespace GTSSO_WinFormsClient.Models.Responses
{
    public class AccessResponse
    {
        [JsonProperty("manageGroupMembership")]
        public bool ManageGroupMembership { get; set; }

        [JsonProperty("view")]
        public bool View { get; set; }

        [JsonProperty("mapRoles")]
        public bool MapRoles { get; set; }

        [JsonProperty("impersonate")]
        public bool Impersonate { get; set; }

        [JsonProperty("manage")]
        public bool Manage { get; set; }
    }
}
