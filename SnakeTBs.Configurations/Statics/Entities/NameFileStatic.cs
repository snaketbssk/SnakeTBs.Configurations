using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Statics.Entities
{
    public static class NameFileStatic
    {
        public static string AppSettings { get; private set; } = "appsettings.json";
        public static void Set(string appSettings)
        {
            AppSettings = appSettings ?? throw new ArgumentNullException(nameof(appSettings));
        }
    }
}
