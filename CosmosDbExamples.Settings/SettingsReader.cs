using Microsoft.Extensions.Configuration;

namespace CosmosDbExamples.Settings
{
    public class SettingsReader : ISettingsReader
    {
#if DEBUG
        private const string DefaultSettingsFilename = "appSettings.local.json";
#else
        private const string DefaultSettingsFilename = "appSettings.json";
#endif
        public T ReadSettings<T>() where T : class, new()
        {
            var settings = new T();
            new ConfigurationBuilder()
                .AddJsonFile(DefaultSettingsFilename)
                .Build()
                .Bind(settings);
           
            return settings;
        }
    }
}