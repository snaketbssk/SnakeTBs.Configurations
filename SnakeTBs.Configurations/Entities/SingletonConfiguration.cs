using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Entities
{
    public abstract class SingletonConfiguration<T> : BaseConfiguration where T : BaseConfiguration, new()
    {
        public readonly static T Instance = new T();
    }
}
