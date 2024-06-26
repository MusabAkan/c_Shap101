﻿public static class Extension
{
    private const string Space = " ";
    private const char Comma = ',';
    private const byte Zero = 0;
    private const string StringEmpty = "";
    private const int number67 = 67;

    public static string SideSilent(this string @string)
    {
        //Önce ünlüleri ayır 
        char[] vowels = ['a', 'A', 'e', 'E', 'ı', 'I', 'i', 'İ', 'o', 'O', 'ö', 'Ö', 'u', 'U', 'ü', 'Ü'];

        string[] spaces = @string.Split(Space);       
        string value = string.Empty;

        foreach (string space in spaces)
        {
            if (space.Contains(Space))
                continue;

            string status = string.Empty;

            for (int i = 0; i < space.Length; i++)
                status += (vowels.FirstOrDefault(x => x.Equals(space[i])) == '\0').ToString() + " ";

            //daha sonrasın ünsüz olanları yakalamaya çalış

            string before = Space, once = Space;

            string[] splits = status.Trim().Split(' ');

            string result = "False";
            for (int i = 0; i < splits.Length; i++)
            {
                once = splits[i];
                if (before == once && before == "True")
                {
                    result = "True";
                    break;
                }
                else
                {
                    if (i == 0)
                        continue;
                    before = once;                         
                }
            }

            value += result + Space;

        }

        return value;
    }
    public static string ChangeFirstLastCharacter(this string @string)
    {
        string value = string.Empty;

        string[] spaces = @string.Split(Space);
        foreach (string space in spaces)
        {
            if (space.Contains(Space))
                continue;

            if (space.Length > 2)
                value += space.Substring(space.Length - 1, 1) + space.Substring(1, space.Length - 2) + space.Substring(Zero, 1) + " ";
            else if (space.Length == 2)
                value += space.Substring(space.Length - 1, 1) + space.Substring(Zero, 1) + " ";
            else
                value += space;
        }

        return value;
    }

    public static string AbsoluteSquareSearch(this string @string)
    {
        string[] spaces = @string.Split(Space);
        int[] numbers = new int[spaces.Length];

        for (int i = Zero; i < spaces.Length; i++)
        {
            if (!spaces[i].Contains(Space))
                numbers[i] = int.Parse(spaces[i]);
        }

        double once = 0, before = 0;

        foreach (int number in numbers)
        {
            if (number < number67)
                once += number67 - number;
            else
                before += Math.Pow(number - number67, 2);
        }

        return $"{once} {before}";

    }
    public static string IntegerBinaries(this string @string)
    {
        string[] spaces = @string.Split(Space);
        int[] numbers = new int[spaces.Length];

        for (int i = Zero; i < spaces.Length; i++)
        {
            if (spaces[i].Contains(Space))
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
            if (space.Contains(Space))
                continue;

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
            if (space.Contains(Space))
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
