using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Twitter
{
    public class TwitterTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            return DateTimeOffset.ParseExact((string)reader.Value, "ddd MMM dd HH:mm:ss +ffff yyyy", new CultureInfo("en-US"), DateTimeStyles.AssumeUniversal);
        }
    }
}