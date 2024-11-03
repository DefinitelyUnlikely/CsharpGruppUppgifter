public class Stick : CollectibleItem
{
    public Stick(
        string name,
        string description,
        string useWith,
        string? useDescription = null
    )
        : base(name, description, useDescription = "A straight stick, suitable for creating tools. ", useWith = "sharpstone") { }

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
            "You have assembled this <stick> to the <sharpstone> \nand now you have a spear that you can use to hunt for food with. "
        );

        CollectibleItem spear = new Spear("spear", "the spear is used to hunt for food", "fish");
        GameManager.player.inventory.RemoveItem("stick");
        GameManager.player.inventory.RemoveItem("stone");
        GameManager.player.inventory.AddItem(spear);
        spear.isCollected = true;
    }
}
