public class HiddenLibraryKey : UsableItem
{
    public HiddenLibraryKey(string name, string description, string? useDescription = null)
        : base(name, description, useDescription) { }

    public override void UseItemWith(string itemName)
    {
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine("Cannot use this key with that object.");
            return;
        }

        Console.WriteLine("The Key clicks!");
        // här hade vi nu bytt kapitel ett steg framåt i mitt room objekt.
    }
}
