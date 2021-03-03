using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterUserLegacy
    {
        [JsonProperty("id_str")]
        public long Id { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }
    }
}