using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Twitter.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ETwitterMediaType
    {
        Photo,
        Video,
        [EnumMember(Value = "animated_gif")]
        Gif
    }
}