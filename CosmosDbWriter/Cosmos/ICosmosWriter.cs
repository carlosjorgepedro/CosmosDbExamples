using System.Threading.Tasks;

namespace CosmosDbExamples.Writer.Cosmos
{
    public interface ICosmosWriter
    {
        Task Write<T>(T document);
    }
}
