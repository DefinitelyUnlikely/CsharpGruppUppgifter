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

        // Fler än 3 strängar borde betyda use * with *
        // Så försöker dela upp item names.
        if (commandArgs.Length > 3)
        {
            string[] items =
                InputManipulationService.GetStringsWithoutWord(commandArgs, "with") ?? [];
            if (items.Length != 2)
                throw new ArgumentException("Invalid input.");
        }

        string itemName = string.Join(" ", commandArgs.Skip(1));
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
