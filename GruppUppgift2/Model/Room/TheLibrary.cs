public class TheLibrary : Room
{
    public TheLibrary(string name, string description, string[] connectsToRoom, Story story, List<GameObject>? items = null)
    : base(name, description, connectsToRoom, story, items)
    {

    }
}
