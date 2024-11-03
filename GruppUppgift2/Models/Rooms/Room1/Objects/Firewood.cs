public class Firewood : CollectibleItem
{
    public Firewood(
        string name, 
        string description, 
        string useWith = "", 
        string? useDescription = null
    )
        : base(name, description, useDescription = "Firewood that you can use to light a fire.", useWith) { }

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
            "You have lit a fire. Now you can sleep in a comfortable temperature and in safety from predators that are afraid of the fire. "
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }
}
