public class Cave : UsableItem
{
    public Cave(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A dark cave that you can sleep in and get shelter from storms. ", useWith) { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine(
            "You wake up in the morning after spending the night in the <cave> on the mountain next to the warm <bonfire> and getting a good night's sleep. You make sure the <bonfire> is completely out and then head back out on the journey to the manned lighthouse again. "
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
