public class Sharpstone : CollectibleItem
{
    public Sharpstone(
        string name,
        string description,
        string useWith,
        string? useDescription = null
    )
        : base(name, description, useDescription = "An arrow shaped sharpstone, suitable for creating tools. ", useWith = "stick") { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine("");
    }

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
            "You have assembled this <sharpstone> to the <stick> \nand now you have a spear that you can use to hunt for food with. "
        );

        CollectibleItem spear = new Spear("spear", "the spear is used to hunt for food", "fish");
        GameManager.player.inventory.RemoveItem("stick");
        GameManager.player.inventory.RemoveItem("sharpstone");
        GameManager.player.inventory.AddItem(spear);
        spear.isCollected = true;
    }
}
