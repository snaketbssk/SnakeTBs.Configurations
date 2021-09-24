using Microsoft.Extensions.Configuration;
using SnakeTBs.Configurations.Models.Entities;
using SnakeTBs.Configurations.Statics.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Entities
{
    internal class RootConfiguration : SingletonConfiguration<RootConfiguration>
    {
        protected override string _nameFile => NameFileStatic.AppSettings;
        public RootAppSettingsModel Root { get; private set; }
        protected override void Load(IConfigurationRoot root)
        {
            Root = new RootAppSettingsModel();
            root.Bind(Root);
        }
    }
}
