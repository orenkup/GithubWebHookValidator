// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using GithubWebhook;
//
//    var data = RepositoryEvent.FromJson(jsonString);

using GithubWebhook.Common;
using Newtonsoft.Json;

namespace GithubWebhook.Events
{
    public partial class TeamEvent
    {
        /// <summary>
        /// This can be one of created, deleted (organization hooks only), archived, unarchived, publicized, or privatized.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }

        [JsonProperty("sender")]
        public User Sender { get; set; }

    }

    public partial class TeamEvent
    {
        public static TeamEvent FromJson(string json) => JsonConvert.DeserializeObject<TeamEvent>(json, Converter.Settings);

        public const string EventString = "team";
    }

}
