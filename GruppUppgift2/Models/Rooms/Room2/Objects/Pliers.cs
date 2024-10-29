public class Room2Pliers : CollectibleItem
{
    public Room2Pliers(
        string name,
        string description,
        string useWith,
        string? useDescription = null
    )
        : base(name, description, useDescription, useWith) { }

    public override void UseItemWith(string itemName)
    {
        if (!this.isCollected)
        {
            Console.WriteLine("You should <take> these to be able to use them.");
            return;
        }
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine($"Cannot use {this.Name} with {itemName}.");
            return;
        }

        Console.WriteLine(
            """
            You manage to pry open the compartment with the pliers.
            A note with a code: '-9--72-' drop out and you stash it in your inventory for safekeeping.
            """
        );

        CollectibleItem note = new CollectibleItem("Note 1", "Note with the code '-9--72-'.");
        GameManager.player.inventory.AddItem(note);
    }
}
