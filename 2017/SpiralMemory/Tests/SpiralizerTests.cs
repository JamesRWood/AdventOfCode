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

        [Fact]
        public void Test2()
        {
            var result = _spiralizer.GetSteps(23);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test3()
        {
            var result = _spiralizer.GetSteps(1024);

            Assert.Equal(31, result);
        }

        [Fact]
        public void Day3_PartA()
        {
            var result = _spiralizer.GetSteps(325489);

            Assert.Equal(552, result);
        }
    }
}
