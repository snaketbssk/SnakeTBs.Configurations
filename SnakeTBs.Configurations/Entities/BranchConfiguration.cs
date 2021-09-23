using Microsoft.Extensions.Configuration;
using SnakeTBs.Configurations.Statics.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Entities
{
    public class BranchConfiguration<T> : SingletonConfiguration<BranchConfiguration<T>> where T : class, new()
    {
        public T Root { get; private set; }
        protected override string _nameFile
        {
            get
            {
                var tag = Environment.GetEnvironmentVariable(EnvironmentVariablesStatic.AspNetCoreBranch);
                var result = RootConfiguration.Instance.Root.AppSettings.GetCurrentNameFile(tag);
                return result;
            }
        }
        protected override void Load(IConfigurationRoot root)
        {
            Root = new T();
            root.Bind(Root);
        }
    }
}
