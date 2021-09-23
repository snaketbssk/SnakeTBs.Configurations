using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Entities
{
    public abstract class BaseConfiguration
    {
        protected abstract string _nameFile { get; }
        protected internal BaseConfiguration()
        {
            PoolConfiguration.Add(this);
            Load();
        }
        ~BaseConfiguration()
        {
            PoolConfiguration.Remove(this);
        }
        public void Load()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile(_nameFile, false);
            var root = configurationBuilder.Build();
            Load(root);
        }
        protected abstract void Load(IConfigurationRoot root);
    }
}
