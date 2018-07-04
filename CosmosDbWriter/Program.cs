using System;
using System.Threading.Tasks;
using CosmosDbWriter.IoC;
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

            Task.Run(worker.Write);

            Console.ReadKey();

            worker.Cancel().Wait();
            Console.WriteLine($"{typeof(Program).Namespace} ended.");
        }
    }
}
