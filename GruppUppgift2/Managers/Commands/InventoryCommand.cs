public class InventoryCommand : Command
{
    public InventoryCommand()
        : base("inventory", "Inventory - List all items in your inventory.") { }

    public override void Execute(string[] commandArgs)
    {
        GameManager.player.inventory.ListInventory();
    }
}
