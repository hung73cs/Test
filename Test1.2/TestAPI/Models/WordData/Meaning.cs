using System.Text.Json.Serialization;

namespace TestAPI.Models.WordDataModels
{
    public class Meaning
    {
        public string? PartOfSpeech { get; set; }

        public List<WordDefinition>? Definitions { get; set; }

        public List<string>? Synonyms { get; set; }

        public List<string>? Antonyms { get; set; }
    }
}
