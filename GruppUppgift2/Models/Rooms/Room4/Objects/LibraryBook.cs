public class LibraryBook : UsableItem
{
    public LibraryBook(string name, string description, string? useDescription = null)
        : base(name, description, useDescription) { }

    public override void UseItem()
    {
        base.UseItem();

        HiddenLibraryKey key =
            new(
                "key",
                "A small <key> that was hidden inside a book.",
                "clock",
                "You need to use this with something."
            );
        RoomManager.currentRoom.Items.Add(key);
    }
}
