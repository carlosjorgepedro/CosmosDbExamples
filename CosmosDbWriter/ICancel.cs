using System.Threading.Tasks;

namespace CosmosDbExamples.Writer
{
    public interface ICancel
    {
        Task Cancel();
    }
}