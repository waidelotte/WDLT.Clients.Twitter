using Newtonsoft.Json;

namespace WDLT.Clients.Twitter.Models
{
    public class TwitterGuestToken
    {
        [JsonProperty("guest_token")]
        public string Value { get; set; }
    }
}