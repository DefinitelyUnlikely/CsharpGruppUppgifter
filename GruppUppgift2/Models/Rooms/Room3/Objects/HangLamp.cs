public class Lamp : UsableItem
{

    public bool isLampoff = false;

    public Lamp(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        isLampoff = !isLampoff;
        if (isLampoff)
        {
            Console.WriteLine("You turned off the lamp. Red squares appear on the wall, hinting at a hidden word.");
            RoomManager.currentRoom.RoomStory.NextChapter();
            RoomManager.currentRoom.Update();
        }
        else
        {
            Console.WriteLine("You turned the lamp on");
            RoomManager.currentRoom.RoomStory.currentChapter = 0;
            RoomManager.currentRoom.Update();
        }
    }

}