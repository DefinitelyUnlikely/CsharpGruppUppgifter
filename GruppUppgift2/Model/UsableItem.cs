// Detta är föremål som skall kunna interageras med på ett sätt som är mer betydelsefullt än
// enbart skriva ut en beskriving vid inspektion. Objekt ska ta hand om sig själva, så mycket kring 
// denna klass tas mycket möjligt hand om av andra klasser.
public class UsableItem : GameObject
{
    private readonly string? UseDescription;
    protected List<GameObject> UsableWith { get; }

    public UsableItem(string name, string description, string? useDescription = null, List<GameObject>? useWith = null)
    : base(name, description)
    {
        UseDescription = useDescription;
        // ?? är en short hand för if (useWith == null) { UsableWith = []; } else { UsableWith = useWith; }
        // Gör så att vi slipper kolla för null i metoden UseItemWith.
        UsableWith = useWith ?? [];
    }


    public virtual void UseItem()
    {
        Console.WriteLine(UseDescription);
    }


    public virtual void UseItemWith(GameObject item)
    {
        if (!UsableWith.Contains(item))
        {
            Console.WriteLine("This seems to do nothing of value");
            return;
        }

        Console.WriteLine();
    }
}
