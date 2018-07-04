using System;
using System.Threading.Tasks;
using CosmosDbWriter.Cosmos;
using CosmosDbWriter.Domain;
using CosmosDbWriter.Generator;
using CosmosDbWriter.IoC;
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
                .RegisterCommonDependencies()
                .BuildServiceProvider();
 
            var worker = serviceProvider.GetService<IWriterService>();
            worker.Write();

            Console.ReadKey();
            Console.WriteLine($"{typeof(Program).Namespace} ended.");
        }
    }

    public interface IWriterService
    {
        Task Write();
    }

    public class WriterService : IWriterService
    {
        private readonly IRandomGenerator _generator;
        private readonly ICosmosWriter _cosmosWriter;

        public WriterService(IRandomGenerator generator, ICosmosWriter cosmosWriter)
        {
            _generator = generator;
            _cosmosWriter = cosmosWriter;
        }

        public Task Write()
        {
            return Task.Run(() =>
            {
                while (true)
                {
                    var user = _generator.Generate<User>();
                    _cosmosWriter.Write(user);
                }
            });
        }
    }

}
