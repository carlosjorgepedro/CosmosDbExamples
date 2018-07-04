using System.Threading.Tasks;

namespace CosmosDbExamples.Writer
{
    public interface IWriterService : ICancel
    {
        Task Write();
    }
}