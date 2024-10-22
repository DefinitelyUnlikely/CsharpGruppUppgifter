public class InnerLibraryDoor(string name, string description, string? useDescription = null, List<GameObject>? useWith = null)
: UsableItem(name, description, useDescription, useWith)
{
    public override void UseItem()
    {

        Console.WriteLine(Description);

        int locksOpen = 0;
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item is CombinationPadlock padlock && padlock.Unlocked) locksOpen++;
        }

        if (locksOpen != 2)
        {
            Console.WriteLine("You need to open both locks first");
            return;
        }

        base.UseItem();
        GameManager.player.completedRooms[4] = true;
        RoomManager.EnterRoom("The Hub");
    }
}



