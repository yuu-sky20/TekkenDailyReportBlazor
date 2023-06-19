using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TekkenDailyReport.Models
{
    [JsonObject]
    public class ModelEmployeeDailyReport
    {
        [JsonProperty("employee-name")]
        [Required]
        public string EmployeeName { get; set; }

        [JsonProperty("daily-report")]
        public ModelDailyReport[] DailyReport { get; set; }

        [JsonProperty("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}
