public class InspectCommand : Command
{
    public InspectCommand()
        : base("inspect", "Inspect <item> - inspects an item in the game world.") { }

    public override void Execute(string[] commandArgs)
    {
        string itemName = InputUtilities.GetInputAsString(commandArgs);
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                item.Display();
                return;
            }
        }

        Console.WriteLine("There is nothing to inspect with that name");
    }
}
