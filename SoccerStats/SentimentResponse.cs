using System.Collections.Generic;
using Newtonsoft.Json;

namespace SoccerStats
{
    public class SentimentResponse
    {
        [JsonProperty("documents")]
        public List<Sentiment> Sentiments { get; set; }

        [JsonProperty("errors")]
        public object[] Errors { get; set; }
    }

    public class Sentiment
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
