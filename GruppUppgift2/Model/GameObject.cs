public class GameObject(string name, string description)
{
    public string Name { get; } = name;
    public string Description { get; set; } = description;

    public virtual void Display()
    {
        Console.WriteLine(Description);
    }
}
