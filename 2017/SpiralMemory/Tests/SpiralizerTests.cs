namespace Tests
{
    using SpiralMemory;
    using Xunit;

    public class SpiralizerTests
    {
        private readonly Spiralizer _spiralizer;

        public SpiralizerTests()
        {
            _spiralizer = new Spiralizer();
        }

        [Fact]
        public void Test()
        {
            var result = _spiralizer.GetSteps(12);

            Assert.Equal(3, result);
        }
    }
}
