using System.Text.Json.Serialization;

namespace TestAPI.Models.WordDataModels
{
    public class Meaning
    {
        [JsonPropertyName("partOfSpeech")]
        public string? PartOfSpeech { get; set; }

        [JsonPropertyName("definitions")]
        public List<WordDefinition>? Definitions { get; set; }

        [JsonPropertyName("synonyms")]
        public List<string>? Synonyms { get; set; }

        [JsonPropertyName("antonyms")]
        public List<string>? Antonyms { get; set; }
    }
}
