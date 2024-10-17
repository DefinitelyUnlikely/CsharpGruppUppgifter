using System.Security.Cryptography.X509Certificates;

public class QuitCommand : Command
{
    public QuitCommand() : base("quit", "Quit - Quits to main menu. If on main menu, quits application.") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        if (GameManager.gameRunning)
        {
            GameManager.gameRunning = false;
        }
        else
        {
            Environment.Exit(0);
        }
    }
}