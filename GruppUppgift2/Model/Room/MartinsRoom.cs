// Detta har nu utvecklats till en klass som egentligen bara håller information som behövs för att skapa mina rum.
// Det gör det lite smidigare att skapa Room objekt sedan.

public class MartinsRoom
{
    public string name = "The Library";
    public string description = "An old study, looking very much like any other library, albeit older and dustier.";



    // Detta är föremålen som finns när rummet skapas. Vi lägger till nyckeln till klockan efter man gör useItem på LibraryBook.
    List<GameObject> items = new()
    {
        new GameObject("Old Chair", "An old chair. As you inspect it closer, you can tell it is marked with the inscription 'Made in 1802'"),
        new GameObject("The library bookcase", "As you take a closer look at the bookcase, you realize none of the books have titles, except one. George Orwell's '1984'."),
        new BrokenClock("Broken Clock", "A broken clock. You notice there is a keyhole in the middle of it.",
        "As you turn the key, the clock face turns as well, leaving the hands behind. Now the big hand points on 3, the small hand on 10."),
        new CombinationPadlock("Library Padlock #1", "A padlock that takes a 4 number combination.", "0412"),
        new CombinationPadlock("Library Padlock #2", "A second padlock that takes a 4 number combination.", "1006"),
        new LibraryBook("The book 1984", "As you pick up the book, you notice it is lighter than it probably should be. You open it up, revealing a hidden key."),
    };

    List<Chapter> chapters = new()
    {
        new Chapter("introduction", @"A dusty old Library. Mold covers the ceiling and even thought you cannot find a light source, the room is brigtly lit. 
            Along one of the walls is a <bookcase>, filled to the brim with books. In a corner you see an old <chair> that looks to be falling apart. 
            Right infront of you is a door, with two <padlocks>. Both take a 4 number combination. Above it is an old <clock>. 
            The large hand is stuck on 12 and the small hand on 4. You can't help but think 'AM or PM', as if that matters."),

        new Chapter("The clock is turned", @"A dusty old Library. Mold covers the ceiling and even thought you cannot find a light source, the room is brigtly lit. 
            Along one of the walls is a <bookcase>, filled to the brim with books. In a corner you see an old <chair> that looks to be falling apart. 
            Right infront of you is a door, with two <padlocks>. Both take a 4 number combination. Above it is an old <clock>. 
            The large hand is now stuck on 6 and the small hand on 10."),
        new Chapter("The padlocks are opened", "The padlocks have been opened, inviting you to open the <door> in front of you.")
    };



    public Room CreateRoom()
    {
        Story story = new Story(chapters);
        return new TheLibrary(name, description, ["The Hub"], story, items);
    }

}