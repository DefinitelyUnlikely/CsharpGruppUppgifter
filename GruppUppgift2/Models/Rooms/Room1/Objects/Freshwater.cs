public class Freshwater : UsableItem
{
    public Freshwater(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A fresh water source, perfect for drinking. ", useWith) { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine(
            "You have drunk this flowing <freshwater>, which you have collected from the crack of the mountain wall, but you still need to find a safe place to spend the night, before it gets to dark. "
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
