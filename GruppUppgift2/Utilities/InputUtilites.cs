using System.Text.RegularExpressions;

public partial class InputUtilities
{
    public static string[]? GetInputWithoutDivider(string[] args, string divider)
    {
        int idx = 0;
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].Equals(divider, StringComparison.OrdinalIgnoreCase))
            {
                idx = i;
            }
        }
        if (idx == 0)
        {
            return null;
        }

        string partOne = string.Join(" ", args.Take(idx).Skip(1));
        string partTwo = string.Join(" ", args.Skip(idx + 1));
        if (string.IsNullOrEmpty(partOne) || string.IsNullOrEmpty(partTwo))
        {
            return null;
        }
        string[] stringArray = [partOne, partTwo];
        return stringArray;
    }

    public static string GetSingleString(string[] args)
    {
        return string.Join(" ", args.Skip(1));
    }

    public static string RemoveNonLetterNonNumber(string input)
    {
        return LetterAndNumber().Replace(input, "");
    }

    // Idé på namn för metod?
    public static string GetInputAsString(string[] commandArgs)
    {
        return RemoveNonLetterNonNumber(GetSingleString(commandArgs));
    }

    [GeneratedRegex("[^a-zA-Z0-9 #]")]
    private static partial Regex LetterAndNumber();
}
