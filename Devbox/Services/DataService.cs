using Devbox.Data.Config;
using Devbox.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Services
{
    internal class DataService : IDataService
    {
        public ConfigJson GetConnectionString()
        {
            var configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "config.json");
            using var fs = File.OpenRead(configFile);
            using var sr = new StreamReader(fs, new UTF8Encoding(false));
            var json = sr.ReadToEnd();

            var configJson = JsonConvert.DeserializeObject<ConfigJson?>(json);

            if (configJson != null)
                return configJson;

            return new ConfigJson();
        }
    }
}
