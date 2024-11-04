public class Cave : UsableItem
{

    public bool isInCave = false;

    public Cave(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useWith) { }

    public override void UseItem()
    {
        isInCave = !isInCave;
        Console.WriteLine(isInCave ? "You enter the cave" : "You exit the cave");
    }

}
