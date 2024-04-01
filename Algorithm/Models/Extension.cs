public static class Extension
{
    private const char Space = ' ';
    private const char Comma = ',';
    public static string ExtractCharacterFromIndex(this string @string)
    {
        string value = string.Empty;
        string[] spaces = @string.Split(Space);

        foreach (string space in spaces)
        {
            if (!space.Contains(Space))
            {
                string[] splits = space.Split(Comma);
                string word = splits[0];
                int index = int.Parse(splits[1]);

                if (index <= (word.Length - 1))
                    value += " " + word.Remove(index, 1);
                else
                    value += " " + word;
            }
        }
        return value.Trim();
    }
}
