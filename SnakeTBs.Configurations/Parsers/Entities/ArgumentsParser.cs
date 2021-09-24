using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTBs.Configurations.Parsers.Entities
{
    public class ArgumentsParser
    {
        private readonly Dictionary<string, string> _arguments = new Dictionary<string, string>();
        public ArgumentsParser(char separator, params string[] args)
        {
            foreach (var arg in args)
            {
                var split = arg.Split(separator);
                var key = split[0];
                var value = split[1];
                _arguments.Add(key: key, value: value);
            }
        }
        public IEnumerable<string> GetKeys()
        {
            var result = _arguments.Keys;
            return result;
        }
        public bool ContainsKey(string key)
        {
            var result = _arguments.ContainsKey(key);
            return result;
        }
        public string GetValue(string key)
        {
            var result = _arguments[key];
            return result;
        }
    }
}
