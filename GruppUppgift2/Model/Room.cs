public class Room : GameObject
{
    public List<GameObject> Items { get; set; }
    public Story story;

    public Room(string name, string description, List<GameObject> items, Story story)
    //: base(name, description)
    {
        Items = items;
        this.story = story;
    }

    public void PrintStory()
    {
        Console.WriteLine(story.GetStoryDescription());
    }
}
