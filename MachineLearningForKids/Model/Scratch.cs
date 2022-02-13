using System.Text.Json.Serialization;

namespace MachineLearningForKids
{
    public class Scratch
    {
        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
