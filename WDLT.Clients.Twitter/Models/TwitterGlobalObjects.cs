using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterGlobalObjects
    {
        [JsonProperty("tweets")]
        public Dictionary<long, TwitterTweet> Tweets { get; set; }

        [JsonProperty("users")]
        public Dictionary<long, TwitterUserLegacy> Users { get; set; }
    }
}