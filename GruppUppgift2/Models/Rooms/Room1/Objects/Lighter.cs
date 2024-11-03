public class Lighter : UsableItem
{
    public Lighter(
        string name, 
        string description, 
        string useWith = "", 
        string? useDescription = null
    )
        : base(name, description, useDescription = "A lighter that you can use to light a fire.", useWith = "firewood") { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine(
            "You have lit a fire. Now you can warm yourself, be safe from predators that fear the fire, and create a smoke signal that will help you be found. "
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
