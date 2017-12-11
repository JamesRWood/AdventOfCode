namespace Captcha
{
    using System.Collections.Generic;
    using System.Linq;

    public class CaptchaCracker
    {
        private readonly List<int> _intList;

        public CaptchaCracker()
        {
            _intList = new List<int>();
        }

        public int Calculate(string inputString, bool modifyIndex)
        {
            DiscoverGroupings(inputString, modifyIndex);
            return _intList.Count > 0 ? _intList.Sum() : 0;
        }

        private void DiscoverGroupings(string inputString, bool modifyIndex)
        {
            var charArray = inputString.ToCharArray();
            var currentIndex = 0;

            while (charArray.Length > currentIndex)
            {
                var nextIndex = DetermineNextIndex(modifyIndex, inputString.Length, currentIndex);
                AddIndexToList(inputString, currentIndex, nextIndex);

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

        private int DetermineNextIndex(bool modifyIndex, int inputLength, int currentIndex)
        {
            if (!modifyIndex)
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
