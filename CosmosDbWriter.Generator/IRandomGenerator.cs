namespace CosmosDbExamples.Generator
{
    public interface IRandomGenerator
    {
        T Generate<T>();
    }
}