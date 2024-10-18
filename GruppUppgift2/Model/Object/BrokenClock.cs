
public class BrokenClock : UsableItem
{
    public BrokenClock(string name, string description, string? useDescription = null, List<GameObject>? useWith = null)
    : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        Console.WriteLine(Description);
        // story.NextChapter();
    }
}