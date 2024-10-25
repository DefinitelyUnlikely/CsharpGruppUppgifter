using System.Linq;

public class UseCommand : Command
{
    public UseCommand()
        : base(
            "use",
            "Use <item> or use <item> with <other item> - use specified item, if possible. "
        ) { }

    public override void Execute(string[] commandArgs)
    {
        if (commandArgs.Length < 2)
        {
            throw new ArgumentException("Use what?");
        }

        if (commandArgs.Contains("with"))
        {
            string[] items = InputUtilities.GetInputWithoutDivider(commandArgs, "with") ?? [];
            if (items.Length != 2)
                throw new ArgumentException("Invalid input. <use item1 with item2>");
            Use(items);
            return;
        }

        string itemName = InputUtilities.GetInputAsString(commandArgs);
        Use(itemName);
    }

    private void Use(string[] items)
    {
        CollectibleItem? inventoryItem = GameManager.player.inventory.GetItemByName(items[0]);
        if (inventoryItem != null)
        {
            inventoryItem.UseItemWith(items[1]);
            return;
        }

        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(items[0]))
            {
                if (item is UsableItem mediator)
                {
                    Console.WriteLine($"Trying to use {items[0]} with {items[1]}.");
                    mediator.UseItemWith(items[1]);
                    return;
                }
            }
        }
        Console.WriteLine("There seems to be no use for that item");
    }

    private void Use(string itemName)
    {
        CollectibleItem? inventoryItem = GameManager.player.inventory.GetItemByName(itemName);
        if (inventoryItem != null)
        {
            inventoryItem.UseItem();
            return;
        }
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(itemName))
            {
                if (item is UsableItem mediator)
                {
                    mediator.UseItem();
                    return;
                }
                else
                {
                    item.Display();
                    return;
                }
            }
        }
        Console.WriteLine("There seems to be no use for that item");
    }
}
