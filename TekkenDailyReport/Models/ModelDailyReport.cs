using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TekkenDailyReport.Models
{
    [JsonObject]
    public class ModelDailyReport
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("construction-number")]
        [Range(0, 10000)]
        public int? Number { get; set; }

        [JsonProperty("work-context")]
        public string? Context { get; set; }
    }
}
