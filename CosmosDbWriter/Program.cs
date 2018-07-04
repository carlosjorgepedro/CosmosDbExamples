using System;
using Microsoft.Extensions.DependencyInjection;

namespace CosmosDbWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Starting {typeof(Program).Namespace}.");

            var serviceProvider = new ServiceCollection()
                .BuildServiceProvider();

            Console.ReadKey();
            Console.WriteLine($"{typeof(Program).Namespace} ended.");
        }
    }
}
