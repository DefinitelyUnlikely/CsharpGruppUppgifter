public class TheLibrary(string name, string description, string[] connectsToRoom, Story story, List<GameObject>? items = null)
 : Room(name, description, connectsToRoom, story, items)
{
    public override void StartRoom()
    {
        Console.WriteLine("En funktion som kallas av vår meny?");
    }
}
