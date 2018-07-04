namespace CosmosDbExamples.Writer.Settings
{
    public interface ISettingsReader
    {
        T ReadSettings<T>() where T : class, new();
    }
}