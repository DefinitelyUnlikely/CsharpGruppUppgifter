public class Boatnoars : CollectibleItem
{
    public Boatnoars(
        string name, 
        string description, 
        string useWith, 
        string? useDescription = null
    )
        : base(name, description, useDescription = "A worn boat with oars used to row the boat across the sea. ", useWith = "sea") { }

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
            "It was a long and tiring journey manually rowing the <boat> with the <oars> against the strong currents of the water, but you have now crossed the <sea> and are finally at the mainland where the lighthouse stands and can now make it to the lighthouse's outer door. "
        );
        RoomManager.currentRoom.RoomStory.NextChapter();        
    }
}
