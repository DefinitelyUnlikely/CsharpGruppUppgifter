public class Boat : CollectibleItem
{
    public bool oarsInBoat = false;

    public Boat(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A worn boat used to cross the sea. ", useWith = "oars") { }

    public override void UseItem()
    {
        if (!oarsInBoat)
        {
            Console.WriteLine("You probably need something to row this with. Perhaps a pair of <oars>?");
            return;
        }
        Console.WriteLine(
        """
        It was a long and tiring journey manually rowing the <boat> with the <oars> against the strong currents of the water, 
        but you have now crossed the <sea> and are finally at the mainland where the lighthouse stands and can now make it to 
        the lighthouse's outer door. 
        """
        );
        Console.WriteLine("press any key to continue the journey");
        Console.ReadKey(true);
        RoomManager.currentRoom.RoomStory.NextChapter();
    }

}
