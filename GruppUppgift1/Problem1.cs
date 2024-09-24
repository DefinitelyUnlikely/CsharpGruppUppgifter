public class ProblemOne
{
    public static void Run()
    {
        int[] MinAndMax(int[] ints)
        {
            return [ints.Min(), ints.Max()];
        }

        int[] minMax = MinAndMax([1, 2, 3, 4, 5]);
        Console.WriteLine($"Min value: {minMax[0]} Max Value: {minMax[1]}.");
    }
}