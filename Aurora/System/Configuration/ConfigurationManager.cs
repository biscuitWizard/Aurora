using System.IO;

using Newtonsoft.Json;

namespace Aurora.System.Configuration
{
    public class ConfigurationManager<T> where T : IConfigurationModel
    {
        public T Configuration { get; protected set; }

        protected ConfigurationManager(T configuration)
        {
            Configuration = configuration;
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(File.Open(Configuration.FileName, FileMode.Create)))
            {
                writer.WriteLine(JsonConvert.SerializeObject(Configuration, Formatting.Indented));
                writer.Flush();
            }
        }

        public static ConfigurationManager<TConfig> LoadConfiguration<TConfig>(string fileName, bool createIfEmpty = true)
            where TConfig : IConfigurationModel, new()
        {
            if (!File.Exists(fileName) && createIfEmpty)
            {
                using (StreamWriter writer = new StreamWriter(File.Open(fileName, FileMode.Create)))
                {
                    TConfig config = new TConfig();
                    writer.WriteLine(JsonConvert.SerializeObject(config, Formatting.Indented));
                    writer.Flush();
                }
            }

            using (StreamReader reader = new StreamReader(File.OpenRead(fileName)))
            {
                string json = reader.ReadToEnd();
                TConfig config = JsonConvert.DeserializeObject<TConfig>(json);

                ConfigurationManager<TConfig> configurationManager = new ConfigurationManager<TConfig>(config);

                return configurationManager;
            }
        }
    }
}
