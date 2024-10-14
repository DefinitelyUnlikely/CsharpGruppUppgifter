
public class BrokenClock : UsableItem
{
    public BrokenClock(string name, string description, string? useDescription = null, List<GameObject>? useWith = null, Dictionary<GameObject, string>? usableWithDescriptions = null)
    : base(name, description, useDescription, useWith, usableWithDescriptions)
    {
    }

    public override void UseItem()
    {
        base.UseItem();
        MartinsRoom.story.NextChapter();
    }
}