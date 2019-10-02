using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SoccerStats
{
    public class NewsSearch
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("readLink")]
        public Uri ReadLink { get; set; }

        [JsonProperty("queryContext")]
        public QueryContext QueryContext { get; set; }

        [JsonProperty("totalEstimatedMatches")]
        public long TotalEstimatedMatches { get; set; }

        [JsonProperty("sort")]
        public Sort[] Sort { get; set; }

        [JsonProperty("value")]
        public List<NewsResult> NewsResult { get; set; }
    }

    public class QueryContext
    {
        [JsonProperty("originalQuery")]
        public string OriginalQuery { get; set; }

        [JsonProperty("adultIntent")]
        public bool AdultIntent { get; set; }
    }

    public class Sort
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public class NewsResult
    {
        [JsonProperty("name")]
        public string HeadLine { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image")]
        public NewsResultImage Image { get; set; }

        [JsonProperty("description")]
        public string Summary { get; set; }

        [JsonProperty("provider")]
        public Provider[] Provider { get; set; }

        [JsonProperty("datePublished")]
        public DateTimeOffset DatePublished { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        public double SentimentScore { get; set; }
    }

    public class NewsResultImage
    {
        [JsonProperty("thumbnail")]
        public PurpleThumbnail Thumbnail { get; set; }
    }

    public class PurpleThumbnail
    {
        [JsonProperty("contentUrl")]
        public Uri ContentUrl { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public class Provider
    {
        [JsonProperty("_type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public ProviderImage Image { get; set; }
    }

    public class ProviderImage
    {
        [JsonProperty("thumbnail")]
        public FluffyThumbnail Thumbnail { get; set; }
    }

    public class FluffyThumbnail
    {
        [JsonProperty("contentUrl")]
        public Uri ContentUrl { get; set; }
    }

    public class Video
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

        [JsonProperty("thumbnail")]
        public VideoThumbnail Thumbnail { get; set; }
    }

    public class VideoThumbnail
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public enum Category { ScienceAndTechnology };

    public enum TypeEnum { Organization };

}
