class Program
{
    static void Main(string[] args)
    {
        // Sätter menyn till MainMenu och kör TryExecuteCommand("help");
        MenuManager.SetMenu(new MainMenu());

        while (true)
        {
            MenuManager.GetCurrentMenu().TryExecuteCommand(Console.ReadLine()!);
        }
    }
}
