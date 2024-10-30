public class Rock : CollectibleItem
{
    public Rock(string name, string description, string useWith, string? useDescription = null)
        : base(name, description, useDescription, useWith) { }

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

        Console.WriteLine("You");

        if (!itemName.Equals("fruit"))
        {
            CollectibleItem spear = new Spear("spear", "Used to catch fish", "fish");
            GameManager.player.inventory.RemoveItem("branch");
            GameManager.player.inventory.RemoveItem("sharpstone");
            GameManager.player.inventory.AddItem(spear);
            return;
        }
    }
}