using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace SnakeTBs.Configurations.Models.Entities
{
    public class AppSettingsModel
    {
        [JsonPropertyName("Tag")]
        public string Tag { get; set; }

        [JsonPropertyName("Files")]
        public List<FileModel> Files { get; set; }
        public string GetCurrentNameFile(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag)) tag = Tag;
            var result = Files.FirstOrDefault(v => v.Tag == tag);
            if (result == null) result = Files.First();
            return result.Name;
        }
    }
}
