class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            MenuManager.GetCurrentMenu().TryExecuteCommand("help");
            MenuManager.GetCurrentMenu().TryExecuteCommand(Console.ReadLine()!);
        }
    }
}
