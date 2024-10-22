public class BrokenClock : UsableItem
{
    public BrokenClock(string name, string description, string? useDescription = null)
        : base(name, description, useDescription) { }

    public override void UseItem()
    {
        Console.WriteLine(Description);
        // story.NextChapter();
    }
}
