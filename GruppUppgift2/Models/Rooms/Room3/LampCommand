public class Lamp : UsableItem
{
    public bool IsLampOff { get; private set; } = false;

    public Lamp(string name, string description) : base(name, description) { }

    public override void UseItem()
    {
        Console.WriteLine(Description);
        string lampAction = Console.ReadLine().ToLower();

        if (lampAction == "turn it off")
        {
            IsLampOff = true;
            Console.WriteLine("You turned off the lamp. Red squares appear on the wall, hinting at a hidden word.");
            RoomManager.currentRoom.RoomStory.NextChapter();
            Console.WriteLine(RoomManager.currentRoom.RoomStory.GetStoryDescription());
        }
        else
        {
            Console.WriteLine("The lamp remains on, and nothing seems to happen. Maybe turning it off could reveal something...");
        }
    }
}
