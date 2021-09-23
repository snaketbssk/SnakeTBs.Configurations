using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Entities
{
    public static class PoolConfiguration
    {
        private static readonly List<BaseConfiguration> _configurations = new List<BaseConfiguration>();
        internal static void Add(BaseConfiguration configuration)
        {
            _configurations.Add(configuration);
        }
        internal static void Remove(BaseConfiguration configuration)
        {
            _configurations.Remove(configuration);
        }
        public static void Load()
        {
            foreach (var configuration in _configurations)
            {
                configuration.Load();
            }
        }
    }
}
