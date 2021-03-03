using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterUserByScreenNameData
    {
        [JsonProperty("user")]
        public TwitterUser User { get; set; }
    }
}