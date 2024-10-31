public class Room2Door : UsableItem
{
    public Room2Door(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        Console.WriteLine("Do you want to enter the room? (y/n)");
        if (Console.ReadLine()!.ToLower().Equals("y"))
        {
            RoomManager.EnterRoom("The Workshop");
        }
        else
        {
            Console.WriteLine("You leave the door for now");
            Console.WriteLine("Hint: You can also enter the room by typing 'Enter <roomname>'.");
        }
    }
}