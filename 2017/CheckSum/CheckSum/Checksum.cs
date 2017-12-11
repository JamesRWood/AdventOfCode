namespace CheckSum
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Checksum
    {
        public int CalculateChecksumValue(string inputFilePath, bool isSecondHalf)
        {
            return Calculate(GetInput(inputFilePath), isSecondHalf);
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

        private static int Calculate(List<List<int>> input, bool isSecondHalf)
        {
            var sumList = new List<int>();
            if (!isSecondHalf)
            {
                input.ForEach(x => sumList.Add(x.Max() - x.Min()));
            }
            else
            {
                foreach (var inp in input)
                {
                    var combinations = inp.SelectMany((value, index) => inp.Skip(index + 1), (first, second) => new { first, second }).ToList();
                    foreach (var c in combinations)
                    {
                        var result = c.first % c.second == 0 ? c.first / c.second : 
                                     c.second % c.first == 0 ? c.second / c.first : 
                                     0;

                        if (result == 0)
                        {
                            continue;
                        }

                        sumList.Add(result);
                        break;
                    }
                }
            }
            
            return sumList.Sum();
        }
    }
}
