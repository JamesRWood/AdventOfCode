namespace Passphrases
{
    using System.Collections.Generic;
    using System.Linq;

    public class PassphraseValidator
    {
        public int CountValidPassphrases(List<string> inputPhrases)
        {
            var result = 0;
            foreach (var phrase in inputPhrases)
            {
                var words = phrase.Split(null).ToList();

                var orderedWords = new List<string>();
                words.ForEach(x => orderedWords.Add(
                        string.Join("", x.ToCharArray().OrderBy(o => o))
                    ));

                var duplicates = orderedWords.GroupBy(x => x)
                                        .Where(g => g.Skip(1).Any())
                                        .Select(g => g.Key)
                                        .ToList();

                result = duplicates.Count == 0 ? result + 1 : result;
            }

            return result;
        }
    }
}
