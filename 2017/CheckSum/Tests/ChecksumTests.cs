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
            RuntTest("Input_Test.txt", 18, false);
        }

        [Fact]
        public void Test2()
        {
            RuntTest("Input.txt", 36174, false);
        }

        [Fact]
        public void Test_SecondHalf()
        {
            RuntTest("Input_Test2.txt", 9, true);
        }

        [Fact]
        public void Test2_SecondHalf()
        {
            RuntTest("Input.txt", 244, true);
        }

        private void RuntTest(string fileName, int expectedOutput, bool isSecondHalf)
        {
            var filePath = Path.GetFullPath(fileName);

            var result = _checksum.CalculateChecksumValue(filePath, isSecondHalf);

            Assert.Equal(expectedOutput, result);
        }
    }
}
