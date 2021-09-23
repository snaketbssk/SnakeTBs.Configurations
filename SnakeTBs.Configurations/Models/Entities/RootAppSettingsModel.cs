using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SnakeTBs.Configurations.Models.Entities
{
    public class RootAppSettingsModel
    {
        [JsonPropertyName("AppSettings")]
        public AppSettingsModel AppSettings { get; set; }
    }
}
