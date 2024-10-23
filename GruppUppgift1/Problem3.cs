
class Problem3
{

    public static void Run()
    {

        Console.Write("Ange filnamnet: ");

        string fileName = Console.ReadLine()!;

        try
        {
            string fileContent = File.ReadAllText(fileName);

            Console.WriteLine("Innehåll i filen:");
            Console.WriteLine(fileContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Filen '{fileName}' hittades inte.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"Du har inte behörighet att läsa filen '{fileName}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ett fel uppstod: {ex.Message}");
        }

    }
}

