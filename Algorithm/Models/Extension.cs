public static class Extension
{
    private const char Space = ' ';
    private const char Comma = ',';
    private const byte Zero = 0;
    private const string StringEmpty = "";

    public static string ReplacesThePreviousCharacter(this string @string)
    {
        string[] spaces = @string.Split(Space);
        string sentence = StringEmpty, value;

        foreach (string space in spaces)
        {
           
            value = StringEmpty;
            int spaceLength = space.Length;
            string[] splits = new string[spaceLength];         

            for (int i = Zero; i < spaceLength; i++)
            {
                int index = i + 1;

                if (i == spaceLength - 1)
                    splits[i] = Convert.ToString(space[Zero]);
                else
                    splits[i] = Convert.ToString(space[index]);
            }

            foreach (string split in splits)
                value += split;

            sentence += Space + value.Trim();
        }
        return sentence.Trim();
    }
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
                    value += Space + word.Remove(index, 1);
                else
                    value += Space + word;
            }
        }
        return value.Trim();
    }
}
