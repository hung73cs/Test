namespace TestAPI.Models.WordDataModels
{
    public class WordDefinition
    {
        public string? Definition { get; set; }
        public List<string>? Synonyms { get; set; }
        public List<string>? Antonyms { get; set; }
        public string? Example { get; set; }
    }
}
