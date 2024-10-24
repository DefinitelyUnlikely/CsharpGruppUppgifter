public class Room
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    private bool isLampOff = false;

    public Room(string name, string description)
    {
        Name = name;
        Description = description;

        Console.WriteLine(description);
        ShowChoices();
    }

    public void StartRoom()
    {
        string action = Console.ReadLine().ToLower();
        while (action != "leave the room")
        {
            if (action == "examine the lamp" || action == "use the lamp")
            {
                LampInteraction();
            }
            else if (action == "sit on the chair")
            {
                ChairInteraction();
            }
            else
            {
                Console.WriteLine("Invalid action.");
            }

            ShowChoices();
            action = Console.ReadLine().ToLower();
        }

        Console.WriteLine("You decide to leave the room. Maybe you'll come back later.");
    }

    public void ShowChoices()
    {
        Console.WriteLine("\nWhat would you like to do next?");
        Console.WriteLine("Choices: 'examine the lamp', 'sit on the chair', or 'leave the room'.");
    }

    private void LampInteraction()
    {
        Console.WriteLine("You approach the lamp. It's a simple lamp. You can either 'turn it off' or 'leave it on'. What do you do?");

        string lampAction = Console.ReadLine().ToLower();
        if (lampAction == "turn it off")
        {
            isLampOff = true;
            Console.WriteLine("You turn off the lamp, and suddenly, red squares appear on the wall. There are as many squares as letters in a hidden word.");
        }
        else
        {
            Console.WriteLine("The lamp remains on, and nothing seems to happen. Maybe turning it off could reveal something...");
        }
    }

    private void ChairInteraction()
    {
        Console.WriteLine("You sit down on the chair in front of the table. There is a strange panel on the table, a module with all the letters of the alphabet.");

        if (isLampOff)
        {
            Console.WriteLine("As the lamp is off, the red squares on the wall seem to interact with the module. It looks like you can use the module to guess letters.");
            StartHangman();
        }
        else
        {
            Console.WriteLine("The module looks inactive. Perhaps something will happen if you turn off the lamp.");
        }
    }

    private void StartHangman()
    {
        List<string> words = new List<string> { "snacka", "kul", "golf", "birdie", "volvo", "lastbil", "karlstad", "varmland", "jobb", "skola" };
        Random random = new Random();
        string chosenWord = words[random.Next(words.Count)];
        char[] guessedWord = new string('_', chosenWord.Length).ToCharArray();
        int attempts = 12;
        List<char> wrongGuesses = new List<char>();

        Console.WriteLine("You must now guess the hidden word by using the module on the table.");
        Console.WriteLine("There are " + chosenWord.Length + " letters in the word.");

        while (attempts > 0 && new string(guessedWord) != chosenWord)
        {
            Console.WriteLine("\nWord: " + new string(guessedWord));
            Console.WriteLine("Wrong guesses: " + string.Join(", ", wrongGuesses));
            Console.WriteLine("You have " + attempts + " attempts remaining. Guess a letter:");

            char guess = Console.ReadLine().ToLower()[0];

            if (chosenWord.Contains(guess))
            {
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == guess)
                    {
                        guessedWord[i] = guess;
                    }
                }
            }
            else
            {
                if (!wrongGuesses.Contains(guess))
                {
                    wrongGuesses.Add(guess);
                    attempts--;
                }
                else
                {
                    Console.WriteLine("You already guessed that letter.");
                }
            }
        }

        if (new string(guessedWord) == chosenWord)
        {
            Console.WriteLine("\nCongratulations! You guessed the word: " + chosenWord);
            Console.WriteLine("The wall starts to rumble, and slowly, a hidden compartment opens up, revealing a box.");
            BoxInteraction();
        }
        else
        {
            Console.WriteLine("\nSorry, you failed the challenge. The word was: " + chosenWord);
            Console.WriteLine("Would you like to 'try again' or 'leave the room'?");

            string tryAgain = Console.ReadLine().ToLower();
            if (tryAgain == "try again")
            {
                StartHangman();
            }
            else
            {
                Console.WriteLine("You decide to leave the room. Maybe you'll try again later.");
            }
        }
    }

    private void BoxInteraction()
    {
        Console.WriteLine("\nYou see a small box inside the hidden compartment. What would you like to do? You can 'approach the box' or 'ignore the box'.");
        string boxAction = Console.ReadLine().ToLower();

        if (boxAction == "approach the box")
        {
            Console.WriteLine("You approach the box. It looks old, but it's not locked. You can 'open the box' or 'leave it'.");
            string openBoxAction = Console.ReadLine().ToLower();

            if (openBoxAction == "open the box")
            {
                Console.WriteLine("You open the box and find a shiny key inside. Would you like to 'take the key' or 'leave the key'?");
                string keyAction = Console.ReadLine().ToLower();

                if (keyAction == "take the key")
                {
                    Console.WriteLine("You take the key. It feels important, as if it might unlock something significant later.");
                    ExitRoom();
                }
                else
                {
                    Console.WriteLine("You decide to leave the key in the box.");
                    ExitRoom();
                }
            }
            else
            {
                Console.WriteLine("You decide to leave the box closed.");
                ExitRoom();
            }
        }
        else
        {
            Console.WriteLine("You decide to ignore the box.");
            ExitRoom();
        }
    }

    private void ExitRoom()
    {
        Console.WriteLine("\nYou have the key in your hand. Would you like to 'leave the room' or 'stay'?");
        string exitAction = Console.ReadLine().ToLower();

        if (exitAction == "leave the room")
        {
            Console.WriteLine("You leave the room, ready to face whatever challenge comes next with the key in your possession.");
        }
        else
        {
            Console.WriteLine("You decide to stay in the room a little longer, but there seems to be nothing else of interest.");
        }
    }
}





//
public class ShowChoicesCommand : Command
{
    public ShowChoicesCommand()
        : base("choices", "ShowChoices - Display possible actions in the current room.") { }

    public override void Execute(string[] commandArgs)
    {
        RoomManager.CurrentRoom.ShowChoices();
    }
}


///
Room myRoom = new Room(
    "Mystery Room",
    "You have entered a seemingly normal room. There is a large wall, a window, " +
    "and a table with a chair in front of the wall. A lamp is hanging from the ceiling. " +
    "The room feels strange, as if it hides more than meets the eye. You sense that something " +
    "might reveal itself if you interact with the objects around you."
);

myRoom.StartRoom();
