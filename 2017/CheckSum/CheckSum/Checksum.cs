namespace CheckSum
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Checksum
    {
        public int CalculateChecksumValue(string inputFilePath)
        {
            return Calculate(GetInput(inputFilePath));
        }

        private static List<List<int>> GetInput(string inputFilePath)
        {
            var inputList = new List<List<int>>();
            var fileReader = new StreamReader(inputFilePath);
            while (!fileReader.EndOfStream)
            {
                var currentRow = fileReader.ReadLine()?.Split(null).Select(int.Parse).ToList();
                inputList.Add(currentRow);
            }

            return inputList;
        }

        private static int Calculate(List<List<int>> input)
        {
            var sumList = new List<int>();
            input.ForEach(x => sumList.Add(x.Max() - x.Min()));

            return sumList.Sum();
        }
    }
}
