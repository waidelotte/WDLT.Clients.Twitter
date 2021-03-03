using Newtonsoft.Json;
using WDLT.Clients.Twitter.Enums;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterMedia
    {
        [JsonProperty("type")]
        public ETwitterMediaType Type { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        [JsonProperty("media_url_https")]
        public string MediaUrlHttps { get; set; }
    }
}