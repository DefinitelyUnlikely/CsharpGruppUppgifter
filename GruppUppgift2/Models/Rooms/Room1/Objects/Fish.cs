public class Fish : UsableItem
{
    public Fish(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A food source, perfect for eating. ", useWith) { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine(
            "You have eaten this <fish> that you caught from the lagoon with the <spear> \nand now you can continue your journey. "
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }

    /*public override void UseItemWith(string itemName)
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
            ""
        );
    }*/
}
