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

    // Vi vill kunna uppdatera vårt rums description om något i rummet ändras.
    // En metod som antagligen ska kallas på av StoryManager eller GameManager.
    // Eller så sköts det helt av story, med kapitel eller dylikt. Vi får se.
    public void UpdateDescription(string newDescription)
    {
        Description = newDescription;
    }

    // Vet inte hur man tänker sig interagera med Room objekt, så jag lägger till denna tills vidare.
    public virtual void StartRoom()
    {
        Console.WriteLine("This is just the base class for the Room Object, ");
    }

    // Tillagt av Olof, så det är kopplat till story.
    // Tyder på att vi inte kommer behöva StartRoom.
    public void PrintStory()
    {
        Console.WriteLine(story.GetStoryDescription());
    }
}
