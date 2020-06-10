using System.Text.Json.Serialization;

namespace BlazorApp.Data
{
    public class GiphyData
    {
        [JsonPropertyName("data")]
       public GiphyDataInner Data { get; set; } 
    }

    public class GiphyDataInner 
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonPropertyName("images")]
        public GiphyImages GiphyImages { get; set; }

        [JsonPropertyName("image_original_url")]
        public string OriginalUrl { get; set; }
    }

    public class GiphyImages
    {
        [JsonPropertyName("downsized_large")]
        public GiphyImage DownsizeLarge { get; set; }
    }

    public class GiphyImage
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }
}