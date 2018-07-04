using System;
using System.Threading.Tasks;
using CosmosDbExamples.Writer.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace CosmosDbExamples.Writer
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
