namespace Tests
{
    using System.IO;
    using CheckSum;
    using Xunit;

    public class ChecksumTests
    {
        private readonly Checksum _checksum;

        public ChecksumTests()
        {
            _checksum = new Checksum();
        }

        [Fact]
        public void Test()
        {
            RuntTest("Input_Test.txt", 18);
        }

        [Fact]
        public void Test2()
        {
            RuntTest("Input.txt", 36174);
        }

        private void RuntTest(string fileName, int expectedOutput)
        {
            var filePath = Path.GetFullPath(fileName);

            var result = _checksum.CalculateChecksumValue(filePath);

            Assert.Equal(expectedOutput, result);
        }
    }
}
