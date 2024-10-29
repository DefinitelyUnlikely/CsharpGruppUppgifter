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
        if (isSatOn)
        {
            Console.WriteLine("You sit down on the chair in front of the table. There is a strange panel with letters on it.");
        }
        else
        {
            Console.WriteLine("You stand up from the chair");
        }
    }
}