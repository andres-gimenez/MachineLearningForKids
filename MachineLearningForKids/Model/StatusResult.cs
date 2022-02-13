using System;
using System.Text.Json.Serialization;

namespace MachineLearningForKids
{
    public class StatusResult
    {
        [JsonPropertyName("msg")]
        public string Message { get; set; }

        [JsonPropertyName("status")]
        public StatusType Status { get; set; }

        public string StatusDescription
        {
            get
            {
                switch (Status)
                {
                    case StatusType.Problem:
                        return "Problem";
                    case StatusType.Training:
                        return "Training is in progress";
                    case StatusType.Ready:
                        return "Ready to use";
                    default:
                        throw new NotSupportedException();
                }
            }

        }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
