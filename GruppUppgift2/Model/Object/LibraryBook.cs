public class LibraryBook : UsableItem
{
    public LibraryBook(string name, string description, string? useDescription = null, List<GameObject>? useWith = null)
    : base(name, description, useDescription, useWith)
    {
    }
}