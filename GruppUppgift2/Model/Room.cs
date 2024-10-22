public class Room : GameObject
{
    public string[] ConnectedRooms { get; }
    public List<GameObject> Items { get; }
    public Story RoomStory { get; }

    // Tillagt av Olof, så det är kopplat till story.
    public Menu? roomMenu { get; }

    public Room(
        string name,
        string description,
        Story story,
        string[] connectedRooms,
        List<GameObject>? items,
        Menu? menu
    )
        : base(name, description)
    {
        RoomStory = story;
        ConnectedRooms = connectedRooms;
        Items = items ?? [];
        roomMenu = menu ?? null;
    }

    public Room(string name, string description, Story story, List<GameObject>? items, Menu? menu)
        : base(name, description)
    {
        RoomStory = story;
        ConnectedRooms = [];
        Items = items ?? [];
        roomMenu = menu ?? null;
    }

    public virtual void StartRoom()
    {
        // Behåll föregående meny om ingen specifik angetts.
        if (roomMenu != null)
        {
            MenuManager.SetMenu(roomMenu);
        }
        Update();
    }

    public virtual void Update()
    {
        Console.WriteLine(RoomStory.GetStoryDescription());
        Console.WriteLine("Type help for a list of commands.");
    }

}
