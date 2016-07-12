using Newtonsoft.Json;

namespace Aurora.System.Configuration
{
    public interface IConfigurationModel
    {
        [JsonIgnore]
        string FileName { get; }
    }
}
