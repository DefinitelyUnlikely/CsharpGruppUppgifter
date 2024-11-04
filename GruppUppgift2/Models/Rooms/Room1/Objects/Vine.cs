public class Vine : CollectibleItem
{
    public Vine(
        string name,
        string description,
        string useWith,
        string? useDescription = null
    )
        : base(name, description, useDescription = "A <vine> to use for climbing with safety. ", useWith = "mountain wall") { }

    public override void UseItem()
    {
        if (!isCollected)
        {
            Console.WriteLine("You should <take> this to be able to use it.");
            return;
        }

        Console.WriteLine("You could probably use these to climb the <mountain wall>");
    }

    public override void UseItemWith(string itemName)
    {
        if (!isCollected)
        {
            Console.WriteLine("You should <take> this to be able to use it.");
            return;
        }
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine($"Cannot use {Name} with {itemName}.");
            return;
        }

        Console.WriteLine(
            "You have tied the <vine> to the <mountain wall> and now you can climb to the other side."
        );

        Console.WriteLine(
            """
            It was a dangerous experience, but it resulted in bringing the player safely on to the other side. 
            Now it's time (once again) to continue the journey to the manned lighthouse.
            """
        );
        Console.WriteLine("press any key to continue the journey");
        Console.ReadKey(true);
        RoomManager.currentRoom.RoomStory.NextChapter();
    }
}
