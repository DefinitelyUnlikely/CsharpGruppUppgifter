class Program
{
    static void Main(string[] args)
    {
        // Sätter menyn till MainMenu och kör TryExecuteCommand("help");
        MenuManager.SetMenu(new MainMenu());
        MenuManager.GetCurrentMenu().TryExecuteCommand("help");

        while (true)
        {
            MenuManager.GetCurrentMenu().TryExecuteCommand(Console.ReadLine()!);
        }
    }
}
