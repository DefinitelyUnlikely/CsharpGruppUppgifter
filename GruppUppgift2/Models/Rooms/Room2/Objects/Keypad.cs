public class Room2Keypad : UsableItem
{
    private string Password { get; }

    public Room2Keypad(
        string name,
        string description,
        string password,
        string? useDescription = null
    )
        : base(name, description, useDescription)
    {
        Password = password;
    }

    public override void UseItem()
    {
        base.UseItem();

        Console.Write("Input code for keypad: ");
        if (!Console.ReadLine()!.ToLower().Equals(Password))
        {
            Console.WriteLine("Nothing happened.");

            return;
        }

        Console.WriteLine(
            "The lock clicks, you open the door and enter what seems to be a laboratory."
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }
}
