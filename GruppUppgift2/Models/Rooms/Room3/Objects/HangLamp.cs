public class Lamp : UsableItem
{

    public bool isLampoff = true;

    public Lamp(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        base.UseItem();
        isLampoff = !isLampoff;
    }

}