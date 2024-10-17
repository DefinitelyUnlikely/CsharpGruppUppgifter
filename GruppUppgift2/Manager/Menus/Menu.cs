public abstract class Menu
{

    private List<Command> commands = [];

    // Om vi kör att alla menyer kan välja help och quit
    // Så tänker jag att de läggs till i vår constructor, så alla menyer har dem utan att behöva tänka på det.
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
                command.Execute(this, commandArgs);
                return;
            }
        }

        Console.WriteLine("There is no such command available at the moment");
    }
}