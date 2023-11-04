using System.Text.Json.Serialization;

namespace TestAPI.Models.WordDataModels
{
    public class License
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
