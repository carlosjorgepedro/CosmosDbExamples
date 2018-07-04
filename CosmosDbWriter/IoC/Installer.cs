using CosmosDbExamples.Generator;
using CosmosDbExamples.Writer.Cosmos;
using CosmosDbExamples.Writer.Settings;
using CosmosDbExamples.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace CosmosDbExamples.Writer.IoC
{
    public static class Installer
    {
        public static IServiceCollection RegisterCommonDependencies(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddSingleton<ISettingsReader, SettingsReader>()
                .AddSingleton(x => x.GetService<ISettingsReader>().ReadSettings<CosmosDbWritterSettings>())
                .AddSingleton(x => x.GetService<CosmosDbWritterSettings>().CosmosDbSettings)
                .AddSingleton<IRandomGenerator, RandomGenerator>()
                .AddSingleton<ICosmosWriter, CosmosWriter>()
                .AddSingleton<IWriterService, WriterService>();

        }
    }
}
