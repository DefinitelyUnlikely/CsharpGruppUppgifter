public class UseCommand : Command
{
    public UseCommand() : base("use", "Use <item> - use specified item, if possible. ") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item.Name.Equals(commandArgs[1]))
            {
                if (item is UsableItem mediator)
                {
                    mediator.UseItem();
                    return;
                }
                else
                {
                    Console.WriteLine(item.Description);
                    return;
                }
            }
        }

        Console.WriteLine("There seems to be no use for that item");
    }
}