
public class LibraryCompletionDoor(string name, string description, string? useDescription = null, List<GameObject>? useWith = null)
: UsableItem(name, description, useDescription, useWith)
{
    public override void UseItem()
    {
        base.UseItem();

    }
}



