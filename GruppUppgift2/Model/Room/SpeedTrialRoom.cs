public class SpeedTrial : Room
{
    public SpeedTrial(string name, string description, string[] connectsToRoom, Story story, List<GameObject>? items = null)
    : base(name, description, connectsToRoom, story, items) { }

    static async Task TimeOutOrRead()
    {
        bool inTime = true;
        using CancellationTokenSource token = new();
        Task readLineTask = Task.Run(() =>
        {
            Console.ReadLine();

            if (inTime)
            {
                Console.WriteLine("This is simply for testing purposes");
                RoomManager.EnterRoom("The Library");
                return;
            }
        },
        token.Token);

        Task timerTask = Task.Delay(5000, token.Token);

        Task completedTask = await Task.WhenAny(readLineTask, timerTask);
        if (completedTask == timerTask)
        {
            token.Cancel();
            inTime = false;
            Console.WriteLine("Too Slow!");
            RoomManager.EnterRoom("The Library");
            return;
        }

    }


    public override async void StartRoom()
    {
        Console.WriteLine("Show me a key!");
        await TimeOutOrRead();
    }
}

// Används för att kunna skapa rummet till vår RoomManager. 
public class SpeedTrialRoom
{
    public string name = "Speed Trial";
    public string description = "...";

    List<Chapter> chapters = new()
    {
        new Chapter("...", "..."),
    };

    public Room CreateRoom()
    {
        Story story = new Story(chapters);
        return new SpeedTrial(name, description, ["The Hub"], story);
    }

}
