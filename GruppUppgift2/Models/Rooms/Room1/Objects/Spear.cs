public class Spear : CollectibleItem
{
    public Spear(
        string name, 
        string description, 
        string useWith, 
        string? useDescription = null
    )
        : base(name, description, useDescription = "A deadly spear that you can use to hunt for food with.", useWith = "fish") { }

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
            "You caught a fish."
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }
}
