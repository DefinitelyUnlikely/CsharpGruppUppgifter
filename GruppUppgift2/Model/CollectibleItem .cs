// Detta är föremål som skall kunna interageras med på ett sätt som är mer betydelsefullt än
// enbart skriva ut en beskriving vid inspektion. Objekt ska ta hand om sig själva, så mycket kring
// denna klass tas mycket möjligt hand om av andra klasser.
public class CollectibleItem : UsableItem
{
    public bool actionOnPickup;
    public bool isCollected = false;

    public CollectibleItem(
        string name,
        string description,
        string? useDescription = null,
        string useWith = "",
        bool actionOnPickup = false
    )
        : base(name, description, useDescription, useWith)
    {
        this.actionOnPickup = actionOnPickup;
    }

    public override void UseItem()
    {
        Console.WriteLine($"Do you want to pick up {Name}?");
        if (Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            MenuManager.GetCurrentMenu().TryExecuteCommand($"take {Name}");
        }
    }

    public override void UseItemWith(string itemName)
    {
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine("This seems to do nothing of value");
            return;
        }

        Console.WriteLine($"Using {this} with {itemName}. Implement function.");
    }

    public void PickedUp()
    {
        // Action on item picked up
    }
}
