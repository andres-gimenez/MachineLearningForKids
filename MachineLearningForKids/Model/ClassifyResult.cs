using System;
using System.Text.Json.Serialization;

namespace MachineLearningForKids
{
    public class ClassifyResult
    {
        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        [JsonPropertyName("confidence")]
        public double Confidence { get; set; }

        [JsonIgnore]
        public double ConfidencePercent => (double)Confidence / 100.0;

        [JsonPropertyName("classifierTimestamp")]
        public DateTime classifierTimestamp { get; set; }
    }
}
