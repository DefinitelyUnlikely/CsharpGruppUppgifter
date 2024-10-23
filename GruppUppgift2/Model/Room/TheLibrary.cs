// Detta har nu utvecklats till en klass som egentligen bara håller information som behövs för att skapa mina rum.
// Det gör det lite smidigare att skapa Room objekt sedan.

public class TheLibrary
{
    public string name = "The Library";
    public string description = "An old study, looking very much like any other library, albeit older and dustier.";
    public Menu menu = new LibraryMenu();

    // Detta är föremålen som finns när rummet skapas. Vi lägger till nyckeln till klockan efter man gör useItem på LibraryBook.
    List<GameObject> items =
        new()
        {
            new GameObject(
                "chair",
                "An old chair. As you inspect it closer, you can tell it is marked with the inscription 'Made in 1802'"
            ),
            new GameObject(
                "bookcase",
                "As you take a closer look at the bookcase, you realize none of the books have titles, except one. George Orwell's <1984>."
            ),
            new BrokenClock(
                "clock",
                "A broken clock. You notice there is a keyhole in the middle of it.",
                "As you turn the key, the clock face turns as well, leaving the hands behind. Now the big hand points on 3, the small hand on 10."
            ),
            new CombinationPadlock(
                "Padlock #1",
                "A padlock that takes a 4 number combination.",
                "0412"
            ),
            new CombinationPadlock(
                "Padlock #2",
                "A second padlock that takes a 4 number combination.",
                "1006"
            ),
            new LibraryBook(
                "1984",
                "A book with no sign of use.",
                "As you pick up the book, you notice it is lighter than it probably should be. You open it up, revealing a hidden key."
            ),

            new InnerLibraryDoor(
                "weird door",
                "A door that cannot be descriped. Not for a lack of features, but your mind simply can't grasp it.",
                "As you open the door, you feel yourself being transported back to the Hub, but with a sense of completion."
            )
        };

    List<Chapter> chapters =
        new()
        {
            new Chapter(
                "introduction",
            @"A dusty old Library.
            Mold covers the ceiling and even thought you cannot find a light source, the room is brigtly lit.
            Along one of the walls is a <bookcase>, filled to the brim with books.
            In a corner you see an old <chair> that looks to be falling apart.
            Right infront of you is a <door>, with two padlocks, marked <Library Padlock #1> and <Library Padlock #2>. Awfully convinient.
            Both take a 4 number combination. Above it is an old <clock>. The large hand is stuck on 12 and the small hand on 4.
            You can't help but think 'AM or PM', as if that matters."
            ),
            new Chapter(
                "The clock is turned",
            @"A dusty old Library. Mold covers the ceiling and even thought you cannot find a light source, the room is brigtly lit. 
            Along one of the walls is a <bookcase>, filled to the brim with books. In a corner you see an old <chair> that looks to be falling apart. 
            Right infront of you is a <weird door>, with two <padlocks>. Both take a 4 number combination. Above it is an old <clock>. 
            The large hand is now stuck on 6 and the small hand on 10."
            ),
            new Chapter(
                "The padlocks are opened",
                "The padlocks have been opened, inviting you to open the <door> in front of you."
            ),
        };

    public Room CreateRoom()
    {
        Story story = new Story(chapters);
        Room room = new(name, description, story, items, menu);
        return room;
    }
}
