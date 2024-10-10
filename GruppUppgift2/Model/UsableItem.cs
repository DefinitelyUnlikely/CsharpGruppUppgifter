namespace GruppUppgift2.Model;


// Detta är föremål som skall kunna interageras med på ett sätt som är mer betydelsefullt än 
// enbart skriva ut en beskriving vid inspektion. Då en del av OOP handlar om att låta objekt
// ta hand om sig självt tänker jag att anmtagligen sköts saker som att ta oss vidare i storyn
// etc. vid använding av rätt föremål inte av denna klassen.
public class UsableItem : GameObject
{

    // kör denna som readonly till att börja med - jag tänker att om UseDescription behöver uppdateras 
    // att det egentligen bör vara ett helt nytt objekt.
    private readonly string? UseDescription;

    // skall föremål som är användbara gå att använda med flera olika
    // föremål? Jag gör en lista ifall att vi tänker det.
    private List<GameObject> UsableWith;

    // En dictionary där vi skickar in ett objekt som nyckel (kanske bör ändras till namn) och en string
    // som vårt värde. Tanken är att vi i denna kan spara beskrivningen för vad som 
    // sker när man använder ett föremål med ett annat - ifall föremålet kan användas på flera olika sätt.
    private Dictionary<GameObject, string> UsableWithDescriptions;


    public UsableItem
    (
        string name, string description, string? useDescription = null,
        List<GameObject>? useWith = null, Dictionary<GameObject, string>? usableWithDescriptions = null
    )
    : base(name, description)
    {
        UseDescription = useDescription;
        // ?? är en short hand för if (useWith == null) { UsableWith = []; } else { UsableWith = useWith; }
        // Så om man inte anger någon lista eller dict för att den inte behövs, sätts den till att vara tom.
        // Gör så att vi slipper kolla för null i UseItemWith.
        UsableWith = useWith ?? [];
        UsableWithDescriptions = usableWithDescriptions ?? [];
    }

    public void UseItem()
    {
        Console.WriteLine(UseDescription);
    }

    // En tanke man kan ha kring denna är att vi använder delegates och då skippar en dictionary.
    // i.e. Vi kan skicka in en metod som argument, för att på det sättet 
    // bestämma ev. kod vid behov.
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
