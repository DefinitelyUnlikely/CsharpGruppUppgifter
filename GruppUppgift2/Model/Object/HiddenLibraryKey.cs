
public class HiddenLibraryKey : UsableItem
{

    public HiddenLibraryKey(string name, string description, string? useDescription = null, List<GameObject>? useWith = null)
    : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItemWith(GameObject item)
    {
        if (!UsableWith.Contains(item))
        {
            Console.WriteLine("Cannot use this key with that object.");
            return;
        }

        Console.WriteLine("The Key clicks!");
        // här hade vi nu bytt kapitel ett steg framåt i mitt room objekt.

    }

}