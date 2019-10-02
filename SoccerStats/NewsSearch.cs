using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SoccerStats
{
    public class NewsSearch
    {
        [JsonProperty("Demo")]
        public Demo Demo { get; set; }

        [JsonProperty("RawJson")]
        public string RawJson { get; set; }

        [JsonProperty("QueryString")]
        public object QueryString { get; set; }

        [JsonProperty("Query")]
        public object Query { get; set; }

        [JsonProperty("Market")]
        public string Market { get; set; }

        [JsonProperty("Freshness")]
        public object Freshness { get; set; }
    }

    public class Demo
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("readLink")]
        public Uri ReadLink { get; set; }

        [JsonProperty("totalEstimatedMatches")]
        public long TotalEstimatedMatches { get; set; }

        [JsonProperty("value")]
        public Value[] Value { get; set; }
    }

    public class Value
    {
        [JsonProperty("about")]
        public About[] About { get; set; }

        [JsonProperty("provider")]
        public Provider[] Provider { get; set; }

        [JsonProperty("datePublished")]
        public DateTimeOffset DatePublished { get; set; }

        [JsonProperty("clusteredArticles")]
        public object ClusteredArticles { get; set; }

        [JsonProperty("mentions")]
        public Mention[] Mentions { get; set; }

        [JsonProperty("video")]
        public object Video { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }

    public class About
    {
        [JsonProperty("readLink")]
        public Uri ReadLink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Image
    {
        [JsonProperty("contentUrl")]
        public object ContentUrl { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty("contentUrl")]
        public Uri ContentUrl { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public class Mention
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Provider
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }


}
