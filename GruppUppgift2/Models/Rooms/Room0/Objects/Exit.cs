public class Exit : UsableItem
{
    public Exit(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        if (!GameManager.player.completedRooms.All(roomBool => roomBool == true))
        {
            Console.WriteLine("The door won't even budge as you try to open it. The light above it shines a bright red, indicating it is locked");
            return;
        }

        Console.WriteLine("As you pull the door open, you find yourself back outside the simulation");
        Console.WriteLine("Congratulations! You have successfully completed the game.");
        Console.WriteLine("Press any key to close the game");
        Console.ReadKey(true);
        Environment.Exit(0);
    }
}