using System.Threading.Tasks;
using CosmosDbWriter.Cosmos;
using CosmosDbWriter.Domain;
using CosmosDbWriter.Generator;

namespace CosmosDbWriter
{
    public class WriterService : IWriterService
    {
        private readonly IRandomGenerator _generator;
        private readonly ICosmosWriter _cosmosWriter;
        private bool _canceled = false;
        public WriterService(IRandomGenerator generator, ICosmosWriter cosmosWriter)
        {
            _generator = generator;
            _cosmosWriter = cosmosWriter;
        }

        public Task Write()
        {
            return Task.Run(() =>
            {
                while (!_canceled)
                {
                    var user = _generator.Generate<User>();
                    _cosmosWriter.Write(user);
                }
            });
        }

        public Task Cancel()
        {
            return Task.Run(() => { this._canceled = true; });
        }
    }
}