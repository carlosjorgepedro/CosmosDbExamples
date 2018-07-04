using System;
using System.Collections.Generic;
using System.Text;
using CosmosDbWriter.Cosmos;
using CosmosDbWriter.Generator;
using CosmosDbWriter.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace CosmosDbWriter.IoC
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
