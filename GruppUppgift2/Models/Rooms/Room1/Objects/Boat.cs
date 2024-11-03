public class Boat : CollectibleItem
{
    public Boat(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A worn boat used to cross the sea. ", useWith = "oars") { }

    /*public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine("");
    }*/

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
            "You have prepared the <boat> and <oars> so that you can begin your journey across the <sea> to the lighthouse. "
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }
}
