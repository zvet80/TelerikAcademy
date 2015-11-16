namespace _03.StringService.Library
{
    public class StringOccurrenceService : IStringOccurrenceService
    {
        public int CountStringOccurrences(string word, string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text.IndexOf(word, i) != -1)
                {
                    count++;
                    i = text.IndexOf(word, i);
                }
            }

            return count;
        }
    }
}
