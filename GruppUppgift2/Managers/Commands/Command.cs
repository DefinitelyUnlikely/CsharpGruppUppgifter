public abstract class Command(string name, string description)
{
    public string Name { get; init; } = name;
    public string HelpDescription { get; } = description;

    public abstract void Execute(string[] commandArgs);
}
