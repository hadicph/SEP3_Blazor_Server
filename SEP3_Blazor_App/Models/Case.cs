using System;
using System.Text.Json.Serialization;

namespace SEP3_Blazor_App.Models
{
    public class Case
    {
        public Case()
        {
        }

        public Case(string userId)
        {
            UserId = userId;
        }
        [JsonPropertyName("userid")]
        public String UserId { get; set; }
        [JsonPropertyName("date")]
        public String Date { get; set; }
        [JsonPropertyName("casedata")]
        public String Casedata { get; set; }
    }
}