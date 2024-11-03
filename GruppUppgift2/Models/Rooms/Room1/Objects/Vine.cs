public class Vine : CollectibleItem
{
    public Vine(
        string name, 
        string description, 
        string useWith, 
        string? useDescription = null
    )
        : base(name, description, useDescription = "A <vine> to use for climbing with safety. ", useWith = "mountainwall") { }

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
            "You have tied this <vine> to the <mountain wall> \nand now you can climb to the other side with safety. "
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }
}
