public class Oars : CollectibleItem
{
    public Oars(
        string name,
        string description,
        string useWith,
        string? useDescription = null
    )
        : base(name, description, useDescription = "Oars used to row the boat. ", useWith = "boat") { }

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
            "You have placed this <oars> inside the <boat> \nand now you have a <boat> and <oars> that you can use to cross the <sea>. "
        );

        CollectibleItem boatnoars = new Boatnoars("boatnoars", "A worn boat with oars used to row the boat across the sea. ", "sea");
        GameManager.player.inventory.RemoveItem("oars");
        GameManager.player.inventory.RemoveItem("boat");
        GameManager.player.inventory.AddItem(boatnoars);
        boatnoars.isCollected = true;
    }
}
