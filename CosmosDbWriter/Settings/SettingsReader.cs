using Microsoft.Extensions.Configuration;

namespace CosmosDbWriter.Settings
{
    public class SettingsReader : ISettingsReader
    {
        private const string DefaultSettingsFilename = "appSettings.json";
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