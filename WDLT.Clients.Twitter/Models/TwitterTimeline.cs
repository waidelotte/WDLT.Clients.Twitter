using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterTimeline
    {
        [JsonProperty("globalObjects")]
        public TwitterGlobalObjects GlobalObjects { get; set; }
    }
}