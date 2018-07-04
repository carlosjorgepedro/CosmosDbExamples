using AutoFixture;

namespace CosmosDbWriter.Generator
{
    public class RandomGenerator : IRandomGenerator
    {
        private readonly Fixture _fixture;

        public RandomGenerator()
        {
            this._fixture = new AutoFixture.Fixture();
        }

        public T Generate<T>()
        {
            return _fixture.Create<T>();
        }
    }
}