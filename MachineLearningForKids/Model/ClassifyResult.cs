using System;
using System.Text.Json.Serialization;

namespace MachineLearningForKids
{
    public class ClassifyResult
    {
        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        [JsonPropertyName("confidence")]
        public int Confidence { get; set; }

        [JsonPropertyName("classifierTimestamp")]
        public DateTime classifierTimestamp { get; set; }
    }
}
