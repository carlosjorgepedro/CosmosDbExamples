using System.Threading.Tasks;

namespace CosmosDbWriter
{
    public interface ICancel
    {
        Task Cancel();
    }
}