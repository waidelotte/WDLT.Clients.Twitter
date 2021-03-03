using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterUserByScreenNameResponse
    {
        [JsonProperty("data")]
        public TwitterUserByScreenNameData Data { get; set; }
    }
}