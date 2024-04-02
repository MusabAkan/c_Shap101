using System;

public static class Extension
{
    private const char Space = ' ';
    private const char Comma = ',';
    private const byte Zero = 0;
    private const string StringEmpty = "";

    public static string IntegerBinaries(this string @string)
    {
        string value = string.Empty;
        string[] spaces = @string.Split(Space);
        int[] numbers = new int[spaces.Length];

        for (int i = Zero; i < spaces.Length; i++)
        {
            if (!spaces[i].Contains(Space))
                numbers[i] = int.Parse(spaces[i]);
        }

        string result = string.Empty;
        int before = 0;

        for (int i = Zero; i < numbers.Length; i++)
        { 
            if (i % 2 != Zero)
            {
                if (numbers[i] == before)
                    result += Math.Pow(numbers[i], before).ToString() + " ";
                else
                    result += Convert.ToString(numbers[i] + before) + " ";
                before = 0;
            }
            else
                before = numbers[i];
        }

        return result;
    }
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
