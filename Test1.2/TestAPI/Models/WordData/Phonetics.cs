using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TestAPI.Models.WordDataModels
{
    public class Phonetics
    {
        public string? Audio { get; set; }

        public string? Text { get; set; }

        public string? SourceUrl { get; set; }

        public License? License { get; set; }
    }
}
