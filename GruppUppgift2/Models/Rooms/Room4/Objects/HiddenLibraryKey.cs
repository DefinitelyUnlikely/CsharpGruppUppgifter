public class HiddenLibraryKey : CollectibleItem
{
    public HiddenLibraryKey(
        string name,
        string description,
        string useWith,
        string? useDescription = null
    )
        : base(name, description, useDescription, useWith) { }

    public override void UseItemWith(string itemName)
    {
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine("Cannot use this key with that object.");
            return;
        }

        Console.WriteLine(
            "The Key clicks!\nAs you turn the key, you notice the clocks face rotates."
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }
}
