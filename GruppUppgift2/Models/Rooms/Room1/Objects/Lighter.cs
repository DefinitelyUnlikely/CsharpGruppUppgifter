public class Lighter : UsableItem
{
    public Lighter(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A lighter that you can use to light a fire.", useWith = "firewood") { }

    public override void UseItem()
    {
        base.UseItem();
        Console.WriteLine("But you're going to need something to make a fire with first.");

    }

    public override void UseItemWith(string itemName)
    {
        if (!UsableWith.Contains(itemName, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Cannot use the lighter to put that on fire.");
            return;
        }

        bool firewoodCollected = false;
        bool insideCave = false;

        foreach (GameObject item in RoomManager.currentRoom.Items.Union(GameManager.player.inventory.GetAllItems()))
        {
            if (item is Cave cave)
            {
                insideCave = cave.isInCave;
                Console.Write("insideCave is ");
                Console.WriteLine(insideCave);
            }

            if (item is Firewood wood)
            {
                firewoodCollected = wood.isCollected;
                Console.Write("firewoodCollected is ");
                Console.WriteLine(firewoodCollected);
            }
        }

        if (firewoodCollected && insideCave)
        {
            Console.WriteLine(
            """
            You have lit a fire. Now you can warm yourself, be safe from predators that fear the fire,
            and create a smoke signal that will help you be found.
            You wake up in the morning after spending the night in the <cave> on the mountain 
            next to the warm <bonfire> and getting a good night's sleep. You make sure the <bonfire> 
            is completely out and then head back out on the journey to the manned lighthouse again.
            """
            );
            Console.WriteLine("press any key to continue the journey");
            Console.ReadKey(true);
            RoomManager.currentRoom.RoomStory.NextChapter();
        }
        else
        {
            Console.WriteLine("You need to both collect the firewood and be inside the cave to do this");
        }

    }

}
