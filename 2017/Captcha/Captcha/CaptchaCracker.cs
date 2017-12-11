namespace Captcha
{
    using System.Collections.Generic;
    using System.Linq;

    public class CaptchaCracker
    {
        private readonly List<int> _intList;
        private static bool _modifyIndex;

        public CaptchaCracker()
        {
            _intList = new List<int>();
        }

        public int Calculate(string inputString, bool modifyIndex)
        {
            _modifyIndex = modifyIndex;

            DiscoverGroupings(inputString);
            return _intList.Count > 0 ? _intList.Sum() : 0;
        }

        private void DiscoverGroupings(string inputString)
        {
            var charArray = inputString.ToCharArray();
            var currentIndex = 0;

            while (charArray.Length > currentIndex)
            {
                AddIndexToList(inputString, currentIndex, DetermineNextIndex(inputString.Length, currentIndex));

                currentIndex++;
            }
        }

        private void AddIndexToList(string inputString, int currentIndex, int nextIndex)
        {
            if (string.Equals(inputString[currentIndex].ToString(), inputString[nextIndex].ToString()))
            {
                _intList.Add(int.Parse(inputString[currentIndex].ToString()));
            }
        }

        private static int DetermineNextIndex(int inputLength, int currentIndex)
        {
            if (!_modifyIndex)
            {
                return currentIndex == inputLength - 1 ? 0 : currentIndex + 1;
            }

            var baseMod = inputLength / 2;
            if (baseMod < inputLength - currentIndex)
            {
                return currentIndex + baseMod;
            }

            if (baseMod + currentIndex == inputLength)
            {
                return 0;
            }

            return baseMod + currentIndex - inputLength;
        }
    }
}
