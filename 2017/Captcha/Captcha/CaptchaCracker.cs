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

        public int Calculate(string inputString, bool indexModifier)
        {
            DiscoverGroupings(inputString, indexModifier);
            return _intList.Count > 0 ? _intList.Sum() : 0;
        }

        private void DiscoverGroupings(string inputString, bool indexModifier)
        {
            var charArray = inputString.ToCharArray();
            var currentIndex = 0;

            while (charArray.Length > currentIndex)
            {
                var nextIndex = currentIndex == charArray.Length - 1 ? 0 : currentIndex + 1;
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
    }
}
