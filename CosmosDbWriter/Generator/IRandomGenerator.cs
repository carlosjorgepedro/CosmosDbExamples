namespace CosmosDbWriter.Generator
{
    public interface IRandomGenerator
    {
        T Generate<T>();
    }
}