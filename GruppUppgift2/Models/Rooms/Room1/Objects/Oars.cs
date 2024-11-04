public class Oars : CollectibleItem
{
    public Oars(
        string name,
        string description,
        string useWith,
        string? useDescription = null
    )
        : base(name, description, useDescription = "Oars used to row the boat.", useWith = "boat") { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine("if you pick them up and put them in the boat, you could probably row the boat across the sea.");
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

        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item is Boat boat)
            {
                boat.oarsInBoat = true;
            }
        }

        Console.WriteLine("You have placed these <oars> inside the <boat> \nand now you have a <boat> that you can use to cross the sea.");
        GameManager.player.inventory.RemoveItem("oars");
    }
}
