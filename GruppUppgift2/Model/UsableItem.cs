// Detta är föremål som skall kunna interageras med på ett sätt som är mer betydelsefullt än
// enbart skriva ut en beskriving vid inspektion. Objekt ska ta hand om sig själva, så mycket kring 
// denna klass tas mycket möjligt hand om av andra klasser.
public class UsableItem : GameObject
{
    private readonly string? UseDescription;
    private List<GameObject> UsableWith;

    // En dictionary där vi skickar in ett objekt som nyckel (kanske bör ändras till namn) och en string
    // som vårt värde. Tanken är att vi i denna kan spara beskrivningen för vad som
    // sker när man använder ett föremål med ett annat - ifall föremålet kan användas på flera olika sätt.
    private Dictionary<GameObject, string> UsableWithDescriptions;

    public UsableItem(
        string name,
        string description,
        string? useDescription = null,
        List<GameObject>? useWith = null,
        Dictionary<GameObject, string>? usableWithDescriptions = null
    )
        : base(name, description)
    {
        UseDescription = useDescription;
        // ?? är en short hand för if (useWith == null) { UsableWith = []; } else { UsableWith = useWith; }
        // Gör så att vi slipper kolla för null i UseItemWith.
        UsableWith = useWith ?? [];
        UsableWithDescriptions = usableWithDescriptions ?? [];
    }

    // Ska annan funktionallitet skötas av Story eller Menu? Annars hade vi kunant göra så
    // att denna tar emot en delegate - Då skapar vi en funktion som vi kan skicka med i objektet när 
    // man skapar det. Eller borde vi egentligen göra så att vi ärver från denna för varje enskilt föremål?
    public virtual void UseItem()
    {
        Console.WriteLine(UseDescription);
    }

    // Kanse ska vi köra namn istället för objektet här, så man inte behöver hålla koll på 
    // antingen index eller variablar som referear till dem.
    public virtual void UseItemWith(GameObject item)
    {
        if (!UsableWith.Contains(item))
        {
            Console.WriteLine("This seems to do nothing of value");
            return;
        }

        Console.WriteLine(UsableWithDescriptions[item]);
    }
}
