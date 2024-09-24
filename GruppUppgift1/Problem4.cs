class Problem4()
{
    public static void Run()
    {
        Console.Write("Skriv in en sträng: ");
        char[] text = Console.ReadLine().ToCharArray();
        char[] reversedText = new char[text.Length];
        int count = 0;

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText[count] = text[i];
            count++;
        }

        Console.WriteLine(reversedText);
    }
}
