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
             """
            The player grabs the <doorhandle> and opens the door to the lighthouse, then the player steps through the door to ask for help. 
            When the player steps inside, everything is pitch black and the door closes by itself afterwards. 
            It takes a while for the light to slowly return, but something is wrong, this is not the inside of a lighthouse. 
            The player finds himself in the Simulator's Hub again and around his neck there is a necklace with a pendant symbolizing a lighthouse. 
            The player exhales and feels relieved. The player has completed all the challenges in the hologram and has received a sovinir 
            around his neck, by stepping into the lighthouse the player has also stepped out of the room at the end. 
            """
        );

        GameManager.player.completedRooms[1] = true;
        Console.WriteLine("press any key to continue.");
        Console.ReadKey(true);
        RoomManager.EnterRoom("The Hub");
    }

}
