using System;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;

namespace CosmosDbWriter.Cosmos
{
    public class CosmosWriter : ICosmosWriter
    {
        private readonly Uri _cosmosUri;
        private readonly string _key;
        private readonly Uri _collectionUri;

        public CosmosWriter(CosmosDbSettings settings)
        {
            _cosmosUri = new Uri(settings.CosmosUri);
            _key = settings.AuthKey;
            _collectionUri = UriFactory.CreateDocumentCollectionUri(settings.DatabaseId, settings.CollectionId);
        }

        public async Task Write<T>(T document)
        {
            var documentClient = new DocumentClient(_cosmosUri, _key);
            await documentClient.CreateDocumentAsync(_collectionUri, document);
        }
    }
}