public class HelpCommand
{
    public static void Execute(string[] Args)
    {
        if (Args.Length < 2)
        {
            Console.WriteLine("Available Commands: help, exit.");
        }
        else
        {
            switch (Args[1])
            {
                case "help":
                {
                    Console.WriteLine("Help shows a list of available commands.");
                    break;
                }
                case "exit":
                {
                    Console.WriteLine("Exit terminates the program.");
                    break;
                }
                case "open":
                {
                    Console.WriteLine("Opens doors, locks or other closed objects.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Available Commands: help, exit.");
                    break;
                }
            }
        }
    }
}
