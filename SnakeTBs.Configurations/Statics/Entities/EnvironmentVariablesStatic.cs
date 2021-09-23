using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Statics.Entities
{
    public static class EnvironmentVariablesStatic
    {
        public static string AspNetCoreBranch { get; private set; } = "ASPNETCORE_BRANCH";
        public static void Set(string aspNetCoreBranch)
        {
            AspNetCoreBranch = aspNetCoreBranch ?? throw new ArgumentNullException(nameof(aspNetCoreBranch));
        }
    }
}
