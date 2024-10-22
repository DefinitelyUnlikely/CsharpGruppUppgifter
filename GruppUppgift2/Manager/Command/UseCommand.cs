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
                throw new ArgumentException("Invalid input.");
            UseWith(items);
            return;
        }

        string itemName = InputUtilities.GetInputAsString(commandArgs);
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

    private void UseWith(string[] items)
    {
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(items[0]))
            {
                if (item is UsableItem mediator)
                {
                    Console.WriteLine($"Trying to use {items[0]} with {items[1]}.");
                    mediator.UseItemWith(items[1]);
                }
                else
                {
                    throw new ArgumentException($"{item.Name} cannot be used.");
                }
            }
        }
    }
}
