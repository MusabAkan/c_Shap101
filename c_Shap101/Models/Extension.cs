public static class Extension
{
    private const char Separator = ' ';
    /// <summary>
    /// Space is check ?
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(Separator);
    }
    /// <summary>
    /// Remove space
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    public static string RemoveWithSpaces(this string param)
    {
        string[] split = param.Split(Separator);
        return string.Join(string.Empty, split);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    /// <summary>
    /// Sort array list.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] SortArray(this int[] arrList)
    {
        Array.Sort(arrList);
        return arrList;
    }
    /// <summary>
    /// String Print to screen
    /// </summary>
    /// <param name="param"></param>
    public static void PrintToScreen(this string param)
    {
        Console.WriteLine(param);
    }
    /// <summary>
    /// Bool Print To Screen
    /// </summary>
    /// <param name="param"></param>
    public static void PrintToScreen(this bool param)
    {
        Console.WriteLine(param);
    }

    public static void PrintToScreenNumberListArray(this int[] arrList)
    {
        foreach (int arr in arrList)
            Console.WriteLine(arr);
    }

    public static bool IsEvenNumber(this int num)
    {
        return num % 2 == 0;
    }

    public static string GetFirstCharacter(this string str)
    {    
        return str.Substring(0, 1);
    }
}