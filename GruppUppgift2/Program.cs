class Program
{
    static void Main(string[] args)
    {
        // Sätter menyn till MainMenu och kör TryExecuteCommand("help");
        MenuManager.SetMenu(new MainMenu());

        // Skapar en lokal variabel för nuvarande meny.
        Menu menu = MenuManager.GetCurrentMenu();
        while (true)
        {
            menu.TryExecuteCommand(Console.ReadLine()!);
        }
    }
}
