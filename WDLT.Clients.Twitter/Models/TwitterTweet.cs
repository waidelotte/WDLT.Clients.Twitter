using System;
using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterTweet
    {
        [JsonProperty("created_at")]
        [JsonConverter(typeof(TwitterTimeConverter))]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id_str")]
        public long Id { get; set; }

        [JsonProperty("quoted_status_id_str")]
        public long? QuotedId{ get; set; }

        [JsonProperty("user_id_str")]
        public long UserId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("entities")]
        public TwitterEntity Entities { get; set; }

        [JsonProperty("extended_entities")]
        public TwitterEntity ExtendedEntities { get; set; }
    }
}