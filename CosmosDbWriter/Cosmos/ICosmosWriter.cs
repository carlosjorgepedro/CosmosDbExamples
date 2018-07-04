using System.Threading.Tasks;

namespace CosmosDbWriter.Cosmos
{
    public interface ICosmosWriter
    {
        Task Write<T>(T document);
    }
}
