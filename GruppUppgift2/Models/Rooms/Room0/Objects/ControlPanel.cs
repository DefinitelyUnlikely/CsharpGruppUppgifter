public class ControlPanel : UsableItem
{
    public ControlPanel(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        if (GameManager.player.completedRooms[1..].Any(roomBool => roomBool == false))
        {
            Console.WriteLine("Some of the lamps still flash red, you probably need to complete more challenges");
            return;
        }

        Console.WriteLine("As you press the button the red light above the exit door turns green, indicating you may leave.");
        GameManager.player.completedRooms[0] = true;
        RoomManager.currentRoom.RoomStory.NextChapter();
    }


    public override void Display()
    {
        Description = UpdateDescription();
        base.Display();
    }

    public string UpdateDescription()
    {
        bool[] completedRooms = GameManager.player.completedRooms[1..];

        string redLights =
        completedRooms.Any(x => x == false) ? $"{completedRooms.Count(x => x == false)} flashing red" : "";
        string greenLights =
        completedRooms.Any(x => x == true) ? $"{completedRooms.Count(x => x == true)} flashing green" : "";
        string divider = (!redLights.Equals("") && !greenLights.Equals("")) ? " and " : "";

        return $"A module with 4 flashing lights, {redLights}{divider}{greenLights}";
    }
}