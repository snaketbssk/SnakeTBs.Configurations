using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SnakeTBs.Configurations.Models.Entities
{
    internal class FileModel
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Tag")]
        public string Tag { get; set; }
    }
}
