using Newtonsoft.Json;

namespace GithubWebhook.Common
{
    public partial class Verification
    {
        [JsonProperty("verified")]
        public bool? Verified { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("signature")]
        public object Signature { get; set; }

        [JsonProperty("payload")]
        public object Payload { get; set; }
    }
}
