using System;
using System.Text.Json.Serialization;

namespace Practice21
{
    public class Book
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("publication_year")]
        public int Year { get; set; }
    }
}
