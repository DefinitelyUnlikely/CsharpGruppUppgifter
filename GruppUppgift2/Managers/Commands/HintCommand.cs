public class HintCommand : Command
{
    public HintCommand()
    : base("hint", "Hint - gives you information about how the game is played")
    {
    }

    public override void Execute(string[] commandArgs)
    {
        string hintText =
        """
        Welcome to the game. What follows is some basic information about how the game is played.

            Objective - The objective of the game is to complete all 4 rooms.
            After completing a room, one of the 4 lights on the <control panel>
            will turn green. When all 4 lights are green, you may use the exit door
            to complete the game. 

            Items in the game world - In the description of the game world,
            some words will have angle brackets <> around them. This indicates that
            the item may be interacted with. Some items can be inspected, some can be used,
            and some may be collected. Some items may need to be used with something to work.
            There are 3 commands for these interactions. 'Inspect', 'Use' and 'Take'. 'Inspect' simply tells
            you an items description. 'Use' will, if possible, use the item. you can also use the use command
            in the following manner: 'use itemA with itemB', this will attempt to use the two items specified 
            with each other. When using the 'use itemA with itemB' command, please keep in mind that the order
            can be important. 'use itemA with itemB' might do nothing, while 'use itemB with itemA' will. 
            Last but not least is the 'Take' command. Some items can be collected into your inventory and be used
            that way. Some items might even need to be in your inventory to be usable. 

            Entering other rooms - To enter the different rooms, there are 2 ways available to you. 
            First is simply using the corresponding door. For example 'use wooden door' would use the 
            wooden door and take you to the room connected to it. You may also enter a room by using the 
            'Enter' command. The command takes a room name as its argument and will, if the room exists and 
            is connected to the room you are currently in, enter that room. Example usage: 'enter the hub'.
            This would enter the main room. Inspecting a door will tell you the name of the room.
            Using 'enter' with any text as its given argument will print a list of the rooms currently connected
            to your room. 

            Good luck and have fun!
        """;
        Console.WriteLine(hintText);
    }
}