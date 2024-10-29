public class Box : UsableItem
{
    public Box(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {

        Console.WriteLine("\nYou see a small box inside the hidden compartment. What would you like to do? You can 'approach the box' or 'ignore the box'.");
        string boxAction = Console.ReadLine()!.ToLower();

        if (boxAction == "approach the box")
        {
            Console.WriteLine("You approach the box. It looks old, but it's not locked. You can 'open the box' or 'leave the box'.");
            string openBoxAction = Console.ReadLine()!.ToLower();

            if (openBoxAction == "open the box")
            {
                Console.WriteLine("You open the box and find a shiny key inside. Would you like to 'take the key' or 'leave the key'?");
                string keyAction = Console.ReadLine()!.ToLower();

                if (keyAction == "take the key")
                {
                    Console.WriteLine("You take the key. It feels important, as if it might unlock something significant later.");
                    GameManager.player.completedRooms[3] = true;
                    Console.WriteLine("You decide to leave for the hub");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                    RoomManager.EnterRoom("The Hub");

                }
                else
                {
                    Console.WriteLine("You decide to leave the key in the box.");

                }
            }
            else
            {
                Console.WriteLine("You decide to leave the box closed.");
            }
        }
        else
        {
            Console.WriteLine("You decide to ignore the box.");
        }

    }
}