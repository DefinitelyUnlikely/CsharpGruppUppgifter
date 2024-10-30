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
