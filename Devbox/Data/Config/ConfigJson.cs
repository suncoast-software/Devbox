using Newtonsoft.Json;

namespace Devbox.Data.Config
{
    internal class ConfigJson
    {
        [JsonProperty("ConnectionString")]
        public string? ConnectionString { get; set; }
    }
}
