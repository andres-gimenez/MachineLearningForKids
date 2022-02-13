using System.Text.Json.Serialization;

namespace MachineLearningForKids
{
    public class ErrorResult
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}
