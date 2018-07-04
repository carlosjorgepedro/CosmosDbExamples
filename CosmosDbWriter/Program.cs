using System;
using CosmosDbWriter.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace CosmosDbWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Starting {typeof(Program).Namespace}.");

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISettingsReader, SettingsReader>()
                .AddSingleton(x => x.GetService<ISettingsReader>().ReadSettings<CosmosDbWritterSettings>())
                .BuildServiceProvider();

            Console.ReadKey();
            Console.WriteLine($"{typeof(Program).Namespace} ended.");
        }

    }
}
