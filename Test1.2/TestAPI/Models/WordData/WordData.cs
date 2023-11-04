using System.ComponentModel;

namespace TestAPI.Models.WordDataModels
{
    public class WordData
    {
        public string? Word { get; set; }
        public List<Phonetics>? Phonetics { get; set; }
        public List<Meaning>? Meanings { get; set; }
        public License? License { get; set; }
        public List<string>? SourceUrls { get; set; }
    }
}
