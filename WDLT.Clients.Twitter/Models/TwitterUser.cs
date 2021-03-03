using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rest_id")]
        public long RestId { get; set; }

        [JsonProperty("legacy")]
        public TwitterUserLegacy Legacy { get; set; }
    }
}