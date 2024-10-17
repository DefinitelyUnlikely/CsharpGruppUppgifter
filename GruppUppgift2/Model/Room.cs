public class Room : GameObject
{
    public string[] ConnectsToRoom { get; }
    public List<GameObject> Items { get; }

    // Tillagt av Olof, så det är kopplat till story.
    public Story story;

    public Room(
        string name,
        string description,
        string[] connectsToRoom,
        Story story,
        List<GameObject>? items = null
    )
    : base(name, description)
    {
        ConnectsToRoom = connectsToRoom;
        Items = items ?? [];
        this.story = story;
    }

    public Room(string name, string description, Story story, List<GameObject>? items = null)
    : base(name, description)
    {
        Items = items ?? [];
        this.story = story;
        ConnectsToRoom = [];
    }

    public virtual void StartRoom()
    {
        Console.WriteLine("This is just the base class for the Room Object, ");
    }

    // Tillagt av Olof, så det är kopplat till story.
    // Tyder på att vi inte kommer behöva StartRoom eller UpdateDescription.
    public void PrintStory()
    {
        Console.WriteLine(story.GetStoryDescription());
    }
}
