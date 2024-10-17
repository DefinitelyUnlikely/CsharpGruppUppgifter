public class LibraryBook : UsableItem
{
    public LibraryBook(string name, string description, string? useDescription = null, List<GameObject>? useWith = null)
    : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        base.UseItem();
        // Lägg till nyckeln i rummet.
        HiddenLibraryKey key = new
        (
            "A hidden key",
            "A small key that was hidden inside a book.",
            "You need to use this with something.",
            [items[2]]
        );
        RoomManager.currentRoom.Items.Add(key);

    }
}