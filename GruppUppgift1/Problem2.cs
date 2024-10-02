class Program
{
    static void Main()
    {
        Console.WriteLine("skriv en mening:");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');

        string lastWord = words[words.Length - 1];

        Console.WriteLine("Sista ordet i meningen är: " + lastWord);
    }
}
