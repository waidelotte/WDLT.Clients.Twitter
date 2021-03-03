using System;
using System.Threading.Tasks;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.Twitter.Models;

namespace WDLT.Clients.Twitter
{
    public class TwitterClient : BaseClient
    {
        public string Bearer { get; set; } = "Bearer AAAAAAAAAAAAAAAAAAAAANRILgAAAAAAnNwIzUejRCOuH5E6I8xnZz4puTs%3D1Zv7ttfk8LF81IUq16cHjhLTvJu4FA33AGWWjCpTnA";
        public string GuestToken { get; set; }

        public TwitterClient(string guestToken, string userAgent) : base("https://api.twitter.com", userAgent)
        {
            GuestToken = guestToken;
        }

        public TwitterClient(string userAgent) : base("https://api.twitter.com", userAgent)
        {

        }

        protected override void OnBeforeRequest(RestClient client, IRestRequest request, Proxy proxy = null)
        {
            request.AddHeader("authorization", Bearer);
            if(!string.IsNullOrWhiteSpace(GuestToken)) request.AddHeader("x-guest-token", GuestToken);
        }

        public Task<TwitterGuestToken> GetGuestTokenAsync()
        {
            return RequestAsync<TwitterGuestToken>(new RestRequest("/1.1/guest/activate.json", Method.POST));
        }

        public Task<TwitterUserByScreenNameResponse> UserByScreenName(string user)
        {
            var request = new RestRequest("/graphql/esn6mjj-y68fNAj45x5IYA/UserByScreenName");

            request.AddQueryParameter("variables", "{\"screen_name\":\"" + user + "\",\"withHighlightedLabel\":false}");

            return RequestAsync<TwitterUserByScreenNameResponse>(request);
        }

        public Task<TwitterTimeline> UserTweetsAsync(long restId, int count = 20)
        {
            var request = new RestRequest($"/2/timeline/profile/{restId}.json?count={count}");
            return RequestAsync<TwitterTimeline>(request);
        }

        public Task<TwitterEmbed> Embed(string url, bool hideConversation = true, bool doNotTrack = true)
        {
            var request = new RestRequest("https://publish.twitter.com/oembed");
            request.AddQueryParameter("url", url);
            if(hideConversation) request.AddQueryParameter("hideConversation", "on");
            request.AddQueryParameter("hide_thread", hideConversation ? "true" : "false");
            if(doNotTrack) request.AddQueryParameter("dnt", "1");

            return RequestAsync<TwitterEmbed>(request);
        }
    }
}
