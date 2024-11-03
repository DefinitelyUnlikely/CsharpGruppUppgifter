public class Doorhandle : UsableItem
{
    public Doorhandle(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "The <doorhandle> opens the door to the lighthouse and allows the player to finish the Hologram-room. ", useWith) { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine(
            "By opening the <doorhandle> to the lighthouse and stepping into the lighthouse, you have now, without understanding what is happening, also stepped out of the Hologram and thus passed this game. "
        );

        GameManager.player.completedRooms[1] = true;
        Console.WriteLine("press any key to continue.");
        Console.ReadKey(true);
        RoomManager.EnterRoom("The Hub");
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
