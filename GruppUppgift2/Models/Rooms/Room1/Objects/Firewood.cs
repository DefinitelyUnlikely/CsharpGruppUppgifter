public class Firewood : CollectibleItem
{
    public Firewood(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "Firewood that you can use to light a fire.", useWith) { }

    public override void UseItem()
    {
        if (!isCollected)
        {
            Console.WriteLine("You should <take> this to be able to use it.");
            return;
        }

        Console.WriteLine("If you only had something to light this on fire with, you could make a fire for the night.");
    }

    public override void UseItemWith(string itemName)
    {
        if (!isCollected)
        {
            Console.WriteLine("You should <take> this to be able to use it.");
            return;
        }

        Console.WriteLine($"You can't use this item with {itemName}");

    }
}
