public class Problem2
{
    public static void Run()
    {
        Console.WriteLine("skriv en mening:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        string lastWord = words[words.Length - 1];

        Console.WriteLine("Sista ordet i meningen är: " + lastWord);
    }
}
