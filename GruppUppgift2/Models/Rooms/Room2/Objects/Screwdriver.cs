public class Room2Screwdriver : CollectibleItem
{
    public Room2Screwdriver(
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
            Console.WriteLine("You should <take> this to be able to use it.");
            return;
        }
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine($"Cannot use {this.Name} with {itemName}.");
            return;
        }

        Console.WriteLine(
            "You've unscrewed the grate and removed it from the shaft. Inside you find a note with a code: '1-23--6'. \nYou stash it in your inventory."
        );

        CollectibleItem note = new CollectibleItem("Note 2", "Note with the code '1-23--6'.");
        GameManager.player.inventory.AddItem(note);
    }
}
