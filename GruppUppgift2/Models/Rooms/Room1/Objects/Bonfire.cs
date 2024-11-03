public class Bonfire : UsableItem
{
    public Bonfire(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A  <bonfire> that provides warmth and protection from predators. ", useWith) { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine(
            "You have lit a <bonfire> that provides warmth and protection from predators. "
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
