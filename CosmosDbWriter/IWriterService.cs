using System.Threading.Tasks;

namespace CosmosDbWriter
{
    public interface IWriterService : ICancel
    {
        Task Write();
    }
}