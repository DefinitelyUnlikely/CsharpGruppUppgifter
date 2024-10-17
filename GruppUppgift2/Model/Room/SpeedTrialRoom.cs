public class SpeedTrial : Room
{
    public SpeedTrial(string name, string description, string[] connectsToRoom, Story story, List<GameObject>? items = null)
    : base(name, description, connectsToRoom, story, items)
    {

    }

    // public async Task TimerTask()
    // {
    //     await Task.Delay(5000);
    //     if ("not player has key")
    //     {
    //         Console.WriteLine("Too slow!");
    //     }
    // }

    public override void StartRoom()
    {
        Console.WriteLine("Enter!");
        Task timerTask = Task.Run(async () =>
        {
            await Task.Delay(5000);
            if (true)  // Placeholder. Kolla om spelaren fått nyckeln genom att trycka på enter. Då skriver vi inte detta.
            {
                Console.WriteLine("Too slow!");
            }
            // Logik för att sparka ut spelaren ur rummet
            // Jag tänker att detta skall skötas via att man agerar med player 
            // och flyttar player.
        });

        if (Console.ReadLine()!.Equals(""))
        {
            // Ge spelaren nyckeln för detta pusslet.
        }
        else
        {
            Console.WriteLine("I said ENTER!");
            // Vänta på att bli utsparkad.
        }
    }
}
