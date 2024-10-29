public class Workshop
{
    // Name of the room.
    string name = "The Workshop";

    // Short introduction to the room. Only shown once?
    // Add a continue command to go to first Chapter.
    string description = """
        You find yourself in an old, abandoned workshop. The room is dimly lit, with flickering 
        fluorescent lights casting eerie shadows. The air is thick with dust, and the faint smell of chemicals lingers.
        """;

    // List of all the items at the start of a room.
    List<GameObject> items1 =
        new()
        {
            new GameObject("Door", "A heavy reinforced steel door with a digital <keypad>"),
            new GameObject(
                "Workbench",
                """
                On the workbench, there are various tools and a partially disassembled <robot>.
                Among the tools, you find a <screwdriver> and a pair of <pliers>.
                """
            ),
            new Room2Screwdriver(
                "Screwdriver",
                "A regular screwdriver. Maybe you can open something with it.",
                "grate",
                "Could come in handy to open the grate."
            ),
            new Room2Pliers(
                "Pliers",
                "A pair of pliers. Maybe you can open something with it.",
                "robot",
                "Maybe you can pry open the compartment on the robot with these."
            ),
            new GameObject(
                "Robot",
                "The robot has a compartment that can probably be opened with a pair of pliers."
            ),
            new Room2Keypad(
                "Keypad",
                "You could open the door if you find the combination.",
                "1923726"
            ),
            new GameObject("grate", "A grate fastened with screws."),
        };

    List<Chapter> chapters =
        new()
        {
            // First Chapter is the main description of the room. (required)
            new Chapter(
                "Workshop",
                """
                You've entered a room that looks like a strange workshop with broken tools
                and oil spills on the floor. There's a cluttered <workbench> and a heavy,
                reinforced door with a digital <keypad>. One of the walls have a <grate>
                covering what seems to be a ventilation shaft.
                """
            ),
            // Optional Chapters after the main one.
            new Chapter(
                "Behind the door",
                """
                On a desk in the middle of the room theres a <computer> terminal.
                One of the walls contains a <poster> of the periodic table. 
                """,
                new()
                {
                    new Room2Computer(
                        "computer",
                        "The computer requires a password to access. You notice a sticky note nearby with a hint: “The key is in the elements.”",
                        "argentina"
                    ),
                    new GameObject(
                        "poster",
                        "The periodic table have five elements circled by a red pen: Nitrogen(N), Sodium(Na), Argon(Ar), Titanium(Ti) and Germanium(Ge)."
                    ),
                }
            ),
        };

    public Room CreateRoom()
    {
        // Story is a class containing all Chapters and keeps track of where in the story you are.
        Story story = new Story(chapters);
        Room room = new(name, description, story, items1, new WorkshopMenu());
        return room;
    }
}


// Name: The Abandoned Laboratory

// Setting: You find yourself in an old, abandoned laboratory. The room is dimly lit, with flickering fluorescent lights casting eerie shadows. The air is thick with dust, and the faint smell of chemicals lingers.

// Objective: Escape the laboratory by solving puzzles and finding clues hidden around the room.

// Key Elements:

//     Locked Door:
//         The main exit is a heavy, reinforced door with a digital keypad. You need to find the code to unlock it.

//     Workbench:
//         On the workbench, there are various tools and a partially disassembled robot. Among the tools, you find a screwdriver and a pair of pliers.

//     Computer Terminal:
//         A computer terminal sits on a desk, but it requires a password to access. You notice a sticky note nearby with a hint: “The key is in the elements.”

//     Periodic Table Poster:
//         On the wall, there’s a poster of the periodic table. You realize the password might be related to the elements. After some thought, you deduce that the password is “H2O” (water).

//     Chemical Cabinet:
//         A locked cabinet contains various chemicals. You find a key hidden under a loose floor tile, which opens the cabinet. Inside, you discover a bottle of acid.

//     Ventilation Shaft:
//         There’s a ventilation shaft covered by a grate. Using the screwdriver, you remove the grate and find a hidden compartment with a journal inside. The journal contains notes about the experiments conducted in the lab and mentions a four-digit code.

//     Robot:
//         The robot on the workbench has a compartment that can be opened with the pliers. Inside, you find a battery and a small key.

//     Final Puzzle:
//         The small key fits into a lockbox on a shelf. Inside the lockbox, you find a UV flashlight. Using the flashlight, you reveal hidden numbers written on the walls, which form the code for the digital keypad.

// Escape: Enter the code into the keypad to unlock the door and escape the laboratory.
// Implementation Tips:

//     Inventory System: Keep track of items the player picks up (e.g., screwdriver, pliers, key, acid, battery).
//     Command Parser: Allow the player to interact with objects using commands like “use screwdriver on grate” or “enter password on computer.”
//     Puzzles: Ensure the puzzles are logical and provide hints to guide the player without making it too easy.

// Would you like more details on any specific part of this scenario?
