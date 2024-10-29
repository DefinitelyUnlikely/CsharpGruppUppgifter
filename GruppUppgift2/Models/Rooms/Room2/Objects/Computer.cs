public class Room2Computer : UsableItem
{
    private string Password { get; }
    private int count = 0;

    public Room2Computer(
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

        Console.Write("Enter password: ");
        if (!Console.ReadLine()!.ToLower().Equals(Password))
        {
            if (count < 2)
            {
                Console.WriteLine("Wrong password. Maybe the periodic table could help.");
            }
            else if (count == 2)
            {
                Console.WriteLine("Wrong password. Maybe you're looking for a country.");
            }
            else
            {
                Console.WriteLine(
                    "Wrong password. You realize the background on the login screen\nis a map of South America. Maybe it has meaning."
                );
            }
            count++;
            return;
        }

        Console.WriteLine(
            """
            It seems like the password was correct. As you're being logged in,
            the entire room seemes to shift around you. The walls dissolves
            into streams of digital code, swirling and converging around the terminal.
            You feel a tingling sensation, as if tiny electrical currents were dancing over your skin.
            In a flash of light, you were no longer in the dimly lit room but standing back in the main hub."
            """
        );

        GameManager.player.completedRooms[2] = true;
        Console.WriteLine("press any key to continue.");
        Console.ReadKey(true);
        RoomManager.EnterRoom("The Hub");
    }
}
