using System.Linq;

namespace CustomerReader.Extensions
{
    public static class StringExtensions
    {        
        public static string FirstLetterToUpper(this string input)
        {
            var words = input.Split(' ').Select(t => t.ToCharArray()).ToList();
            words.ForEach(t =>
            {
                for (int i = 0; i < t.Length; i++)
                {
                    t[i] = i.Equals(0) ? char.ToUpper(t[i]) : char.ToLower(t[i]);
                }
            });
            return string.Join(" ", words.Select(t => new string(t)));
        }

    }
}
