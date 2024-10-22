public class TakeCommand : Command
{
    public TakeCommand()
        : base("take", "Take <item> - picks up specified item, if possible. ") { }

    public override void Execute(string[] commandArgs)
    {
        if (commandArgs.Length < 2)
        {
            throw new ArgumentException("Take what?");
        }

        string itemName = InputUtilities.GetInputAsString(commandArgs);

        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(itemName))
            {
                if (item is CollectibleItem mediator)
                {
                    GameManager.player.inventory.AddItem(mediator);
                    Console.WriteLine($"Picked up {itemName}");
                    if (mediator.actionOnPickup)
                    {
                        mediator.PickedUp();
                    }
                    // Kanske inte alltid ska ta bort från rummet?
                    // RoomManager.currentRoom.Items.Remove(mediator);
                    return;
                }
                else
                {
                    item.Display();
                    return;
                }
            }
        }

        Console.WriteLine($"There is no {itemName} to take.");
    }
}
