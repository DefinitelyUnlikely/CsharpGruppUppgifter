public class Chair : UsableItem
{
    public bool isSatOn = false;

    public Chair(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        base.UseItem();
        isSatOn = !isSatOn;
    }
}