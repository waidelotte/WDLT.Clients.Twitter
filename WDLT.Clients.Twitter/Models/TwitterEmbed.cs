using System;
using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterEmbed
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_url")]
        public Uri AuthorUrl { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }
}