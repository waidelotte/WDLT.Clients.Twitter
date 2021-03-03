using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterEntity
    {
        [JsonProperty("media")]
        public List<TwitterMedia> Media { get; set; }
    }
}