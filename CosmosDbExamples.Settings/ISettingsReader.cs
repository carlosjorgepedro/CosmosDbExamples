namespace CosmosDbExamples.Settings
{
    public interface ISettingsReader
    {
        T ReadSettings<T>() where T : class, new();
    }
}