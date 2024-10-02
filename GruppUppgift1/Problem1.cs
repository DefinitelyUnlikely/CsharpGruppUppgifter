namespace GruppUppgift1;

public class Problem1
{
    public static void Run()
    {

        // Om man vill hade denna funktion kunna innehålla allt som är inuti run
        // och vi skippar returnen. Men jag tänker att en funktion som bara skickar tillbaka 
        // min och max för en int[] är mer återandvändbar än en som tvingar dig att skriva in saker i 
        // terminalen etc. 
        static int[] MinAndMax(int[] ints)
        {
            return [ints.Min(), ints.Max()];
        }

        Console.Write("Please enter numbers separated by whitespace: ");
        string[] strNumbers = Console.ReadLine()!.Split(null);

        // Då vi inte behöver/skall felhantera eller validera, kör vi Parse istället för TryParse.
        // Då krashar programmet så fort användaren gör fel.
        int counter = 0;
        int[] ints = new int[strNumbers.Length];
        Array.ForEach(strNumbers, strNum => { ints[counter++] = int.Parse(strNum); });

        int[] minMax = MinAndMax(ints);
        Console.WriteLine($"Min value: {minMax[0]} Max Value: {minMax[1]}.");
    }
}
