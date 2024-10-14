public class MartinsRoom
{
    string name = "The Library";
    // Detta kanske också skall vara kapitel 1 i storyn?
    string description =
    @"A dusty old Library. Mold covers the ceiling and even thought you cannot find a light source, the room is brigtly lit. 
    Along one of the walls is a <bookcase>, filled to the brim with books. In a corner you see an old <chair> that looks to be falling apart. 
    Right infront of you is a door, with two <padlocks>. Both take a 4 number combination. Above it is an old <clock>. 
    The large hand is stuck on 12 and the small hand on 4. You can't help but think 'AM or PM', as if that matters.";

    List<GameObject> items = new()
    {
        new GameObject("Old Chair", "An old chair. As you inspect it closer, you can tell it is marked with the inscription 'Made in 1802'"),
        new GameObject("The library bookcase", "As you take a closer look at the bookcase, you realize none of the books have titles, except one. George Orwell's '1984'."),
        new BrokenClock("Broken Clock", "A broken clock. You notice there is a keyhole in the middle of it.",
        "As you turn the key, the clock face turns as well, leaving the hands behind. Now the big hand points on 3, the small hand on 10."),
        new CombinationPadlock("Library Padlock #1", "A padlock that takes a 4 number combination.", "0412"),
        new CombinationPadlock("Library Padlock #2", "A second padlock that takes a 4 number combination.", "1006"),
        new LibraryBook("The book 1984", "As you pick up the book, you notice it is lighter than it probably should be. You open it up, revealing a hidden key."),
        new HiddenLibraryKey("A hidden key", "A small key that was hidden inside a book."),
    };


}