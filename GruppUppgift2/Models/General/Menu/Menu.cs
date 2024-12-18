public abstract class Menu
{
    private List<Command> commands = [];

    public Menu()
    {
        AddCommand(new QuitCommand());
        AddCommand(new HelpCommand());
    }

    protected void AddCommand(Command command)
    {
        commands.Add(command);
    }

    public List<Command> GetCommands()
    {
        return commands;
    }

    public void TryExecuteCommand(string input)
    {
        string[] commandArgs = input.Split(" ");
        string commandName = commandArgs[0].ToLower();

        foreach (Command command in commands)
        {
            if (command.Name.Equals(commandName))
            {
                try
                {
                    command.Execute(commandArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return;
            }
        }

        Console.WriteLine("There is no such command available at the moment");
    }
}
