public class UsableItem : GameObject
{
    protected readonly string? UseDescription;
    protected string UsableWith { get; }

    public UsableItem(
        string name,
        string description,
        string? useDescription = null,
        string useWith = ""
    )
        : base(name, description)
    {
        UseDescription = useDescription;
        UsableWith = useWith;
    }

    public virtual void UseItem()
    {
        if (UseDescription != null)
            Console.WriteLine(UseDescription);
    }

    public virtual void UseItemWith(string itemName)
    {
        if (!UsableWith.Contains(itemName, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("This seems to do nothing of value");
            return;
        }

        // Implement your usecase logic in the inherited class.
    }
}
