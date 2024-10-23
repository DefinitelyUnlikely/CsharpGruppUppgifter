public class InnerLibraryDoor(string name, string description, string? useDescription = null)
    : UsableItem(name, description, useDescription)
{
    public override void UseItem()
    {
        Console.WriteLine(Description);

        int locksOpen = 0;
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item is CombinationPadlock padlock && padlock.Unlocked)
                locksOpen++;
        }

        if (locksOpen != 2)
        {
            Console.WriteLine("You need to open both locks first");
            return;
        }

        base.UseItem();
        GameManager.player.completedRooms[4] = true;
        Thread.Sleep(3000);
        RoomManager.EnterRoom("The Hub");
    }
}
