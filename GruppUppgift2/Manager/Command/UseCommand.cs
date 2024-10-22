using System.Linq;

public class UseCommand : Command
{
    public UseCommand()
        : base("use", "Use <item> - use specified item, if possible. ") { }

    public override void Execute(string[] commandArgs)
    {
        if (commandArgs.Length < 2)
        {
            throw new ArgumentException("Use what?");
        }

        if (commandArgs.Contains("with"))
        {
            string[] items = InputUtilities.GetStringsWithoutWord(commandArgs, "with") ?? [];
            if (items.Length != 2)
                throw new ArgumentException("Invalid input.");
            UseWith(items);
            return;
        }

        string itemName = InputUtilities.GetCleanString(commandArgs);
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
