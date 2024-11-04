public class Fish : UsableItem
{
    public bool caught = false;

    public Fish(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A food source, perfect for eating. ", useWith) { }

    public override void UseItem()
    {
        if (!caught)
        {
            Console.WriteLine("Need to catch the fish first");
            return;
        }

        Console.WriteLine("You have eaten this <fish> that you caught from the lagoon with the <spear> \nand now you can continue your journey. ");
        Console.WriteLine("press any key to continue the journey");
        Console.ReadKey(true);
        RoomManager.currentRoom.RoomStory.NextChapter();
    }

}
