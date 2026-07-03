// Extension methods - методы расширения
static class StringExtensions
{
    public static int CountWords(this string text)
    {
        var words = text.Split(' ');
        return words.Length;
    }

    public static int CountSpaces(this string text)
    {
        var spaces = text.Split(' ');
        return spaces.Length - 1;
    }

    public static int CountVowels(this string text)
    {
        int count = 0;
        foreach (char c in text)
        {
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                count++;
            }
        }
        return count;
    }

    public static int ToInt(this string str) => int.TryParse(str, out int result) ? result : 0;
}
