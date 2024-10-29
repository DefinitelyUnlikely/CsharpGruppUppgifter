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
        base.UseItem();
        if (!isCollected)
        {
            Console.WriteLine($"Maybe you want to <take> {this.Name}.");
        }
    }

    public void PickedUp()
    {
        // Action on item picked up
    }
}
